using System.Diagnostics;

namespace Memoria_Estatica
{
    public sealed class DynamicMemoryResult
    {
        public int ActiveInstances { get; init; }
        public long HeapMemoryBytes { get; init; }
        public long MemoryDeltaBytes { get; init; }
        public double ElapsedMilliseconds { get; init; }
        public string Message { get; init; } = string.Empty;
    }

    public sealed class DynamicMemoryManager
    {
        private readonly List<HeapObject> _references = new();
        private HeapObject? _head;
        private HeapObject? _tail;
        private int _nextId = 1;
        private readonly Random _random = new();

        public int ActiveInstances => _references.Count;

        public DynamicMemoryResult CreateInstances(int count, int payloadSizeBytes = 256)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count cannot be negative.");
            }

            long memoryBefore = GC.GetTotalMemory(false);
            var stopwatch = Stopwatch.StartNew();

            _references.Clear();
            _head = null;
            _tail = null;
            _nextId = 1;

            for (int i = 0; i < count; i++)
            {
                AppendNodeInternal($"Obj_{_nextId}", payloadSizeBytes);
            }

            stopwatch.Stop();
            long memoryAfter = GC.GetTotalMemory(false);

            return new DynamicMemoryResult
            {
                ActiveInstances = _references.Count,
                HeapMemoryBytes = memoryAfter,
                MemoryDeltaBytes = memoryAfter - memoryBefore,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                Message = $"Created {_references.Count:N0} dynamic instances on the Heap."
            };
        }

        public DynamicMemoryResult AddInstance(string label = "Dynamic", int payloadSizeBytes = 256)
        {
            long memoryBefore = GC.GetTotalMemory(false);
            var stopwatch = Stopwatch.StartNew();

            HeapObject created = AppendNodeInternal($"{label}_{_nextId}", payloadSizeBytes);

            stopwatch.Stop();
            long memoryAfter = GC.GetTotalMemory(false);

            return new DynamicMemoryResult
            {
                ActiveInstances = _references.Count,
                HeapMemoryBytes = memoryAfter,
                MemoryDeltaBytes = memoryAfter - memoryBefore,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                Message = $"Instance ID:{created.Id} (Ref:0x{created.ReferenceCode:X8}) added to Heap."
            };
        }

        public DynamicMemoryResult TestReference(int index = 0)
        {
            if (_references.Count == 0)
            {
                return new DynamicMemoryResult
                {
                    ActiveInstances = 0,
                    HeapMemoryBytes = GC.GetTotalMemory(false),
                    MemoryDeltaBytes = 0,
                    ElapsedMilliseconds = 0,
                    Message = "No active Heap instances available to test references."
                };
            }

            int clampedIndex = Math.Clamp(index, 0, _references.Count - 1);
            HeapObject refA = _references[clampedIndex];
            HeapObject refB = refA;

            int previousValue = refA.Value;
            refB.Value += 100;
            bool sameInstance = ReferenceEquals(refA, refB);

            return new DynamicMemoryResult
            {
                ActiveInstances = _references.Count,
                HeapMemoryBytes = GC.GetTotalMemory(false),
                MemoryDeltaBytes = 0,
                ElapsedMilliseconds = 0,
                Message = $"RefA & RefB -> 0x{refA.ReferenceCode:X8} (Same: {sameInstance}). Value: {previousValue} -> {refA.Value}."
            };
        }

        public DynamicMemoryResult ReleaseAllAndCollect()
        {
            long memoryBefore = GC.GetTotalMemory(false);
            var stopwatch = Stopwatch.StartNew();

            _head = null;
            _tail = null;
            _references.Clear();
            _nextId = 1;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            stopwatch.Stop();
            long memoryAfter = GC.GetTotalMemory(true);

            return new DynamicMemoryResult
            {
                ActiveInstances = 0,
                HeapMemoryBytes = memoryAfter,
                MemoryDeltaBytes = memoryAfter - memoryBefore,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                Message = $"References cleared and GC completed. Heap: {memoryBefore:N0} B -> {memoryAfter:N0} B."
            };
        }

        public IReadOnlyList<string> GetPreview(int maxItems = 200)
        {
            if (_references.Count == 0)
            {
                return new[] { "(No active Heap instances)" };
            }

            int limit = Math.Min(_references.Count, maxItems);
            var preview = new List<string>(limit + 1);

            for (int i = 0; i < limit; i++)
            {
                preview.Add(_references[i].ToString());
            }

            if (_references.Count > maxItems)
            {
                preview.Add($"... ({_references.Count - maxItems:N0} more instances omitted from preview)");
            }

            return preview;
        }

        public Task<DynamicMemoryResult> RunBenchmarkAsync(int objectCount, int payloadSizeBytes = 256)
        {
            return Task.Run(() =>
            {
                ReleaseAllAndCollect();
                return CreateInstances(objectCount, payloadSizeBytes);
            });
        }

        private HeapObject AppendNodeInternal(string label, int payloadSizeBytes)
        {
            var created = new HeapObject(_nextId++, label, _random.Next(1, 1000), payloadSizeBytes);

            if (_head == null)
            {
                _head = created;
                _tail = created;
            }
            else
            {
                _tail!.Next = created;
                _tail = created;
            }

            _references.Add(created);
            return created;
        }
    }
}
