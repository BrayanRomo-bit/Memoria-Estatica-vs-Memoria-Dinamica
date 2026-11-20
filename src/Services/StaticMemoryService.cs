using System.Diagnostics;
using System.Runtime.CompilerServices;
using MemoryComparison.Models;

namespace MemoryComparison.Services
{
    public sealed class StaticMemoryService
    {
        private int[] _vector = Array.Empty<int>();
        private readonly Random _random = new();

        public int CurrentSize => _vector.Length;

        public long EstimatedMemoryBytes => (long)_vector.Length * sizeof(int);

        public int CurrentReferenceCode => _vector.Length == 0 ? 0 : RuntimeHelpers.GetHashCode(_vector);

        public StaticMemoryOperationResult GenerateVector(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Size cannot be negative.");
            }

            int previousReference = CurrentReferenceCode;
            var stopwatch = Stopwatch.StartNew();

            _vector = new int[size];
            for (int i = 0; i < _vector.Length; i++)
            {
                _vector[i] = _random.Next(1, 1000);
            }

            stopwatch.Stop();
            int newReference = CurrentReferenceCode;

            return new StaticMemoryOperationResult
            {
                CurrentSize = _vector.Length,
                EstimatedMemoryBytes = EstimatedMemoryBytes,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                BlockReferenceCode = newReference,
                BlockReallocated = previousReference != newReference,
                Message = $"Vector generated with {_vector.Length:N0} integers."
            };
        }

        public StaticMemoryOperationResult ResizeVector(int newSize)
        {
            if (newSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newSize), "New size cannot be negative.");
            }

            int previousSize = _vector.Length;
            int previousReference = CurrentReferenceCode;
            var stopwatch = Stopwatch.StartNew();

            Array.Resize(ref _vector, newSize);

            for (int i = previousSize; i < _vector.Length; i++)
            {
                _vector[i] = _random.Next(1, 1000);
            }

            stopwatch.Stop();
            int newReference = CurrentReferenceCode;

            return new StaticMemoryOperationResult
            {
                CurrentSize = _vector.Length,
                EstimatedMemoryBytes = EstimatedMemoryBytes,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                BlockReferenceCode = newReference,
                BlockReallocated = previousReference != newReference,
                Message = $"Vector resized from {previousSize:N0} to {_vector.Length:N0} elements."
            };
        }

        public void Clear()
        {
            _vector = Array.Empty<int>();
        }

        public IReadOnlyList<string> GetPreview(int maxItems = 200)
        {
            if (_vector.Length == 0)
            {
                return new[] { "(Empty vector)" };
            }

            int limit = Math.Min(_vector.Length, maxItems);
            var preview = new List<string>(limit + 1);

            for (int i = 0; i < limit; i++)
            {
                preview.Add($"[{i}] = {_vector[i]}");
            }

            if (_vector.Length > maxItems)
            {
                preview.Add($"... ({_vector.Length - maxItems:N0} more elements omitted from preview)");
            }

            return preview;
        }

        public Task<StaticMemoryOperationResult> RunBenchmarkAsync(int initialSize, int resizedSize)
        {
            return Task.Run(() =>
            {
                Clear();
                var stopwatch = Stopwatch.StartNew();

                GenerateVector(initialSize);
                StaticMemoryOperationResult resizeResult = ResizeVector(resizedSize);

                stopwatch.Stop();

                return new StaticMemoryOperationResult
                {
                    CurrentSize = resizeResult.CurrentSize,
                    EstimatedMemoryBytes = resizeResult.EstimatedMemoryBytes,
                    ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                    BlockReferenceCode = resizeResult.BlockReferenceCode,
                    BlockReallocated = resizeResult.BlockReallocated,
                    Message = $"Static benchmark ({initialSize:N0} -> {resizedSize:N0}) completed."
                };
            });
        }
    }
}
