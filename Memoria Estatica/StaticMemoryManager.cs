using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Memoria_Estatica
{
    /// <summary>
    /// Result of an operation performed on static memory (contiguous arrays).
    /// </summary>
    public sealed class StaticMemoryResult
    {
        public int CurrentSize { get; init; }
        public long EstimatedMemoryBytes { get; init; }
        public double ElapsedMilliseconds { get; init; }
        public int BlockReferenceCode { get; init; }
        public bool BlockReallocated { get; init; }
        public string Message { get; init; } = string.Empty;
    }

    /// <summary>
    /// Exclusively manages fixed-size arrays at runtime and their resizing
    /// through contiguous block reallocation.
    /// </summary>
    public sealed class StaticMemoryManager
    {
        private int[] _vector = Array.Empty<int>();
        private readonly Random _random = new();

        public int CurrentSize => _vector.Length;

        public long EstimatedMemoryBytes => (long)_vector.Length * sizeof(int);

        public int CurrentReferenceCode => _vector.Length == 0 ? 0 : RuntimeHelpers.GetHashCode(_vector);

        /// <summary>
        /// Allocates a new contiguous array of the specified size and initializes it.
        /// </summary>
        public StaticMemoryResult GenerateVector(int size)
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

            return new StaticMemoryResult
            {
                CurrentSize = _vector.Length,
                EstimatedMemoryBytes = EstimatedMemoryBytes,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                BlockReferenceCode = newReference,
                BlockReallocated = previousReference != newReference,
                Message = $"Vector generated with {_vector.Length:N0} integers."
            };
        }

        /// <summary>
        /// Resizes the array at runtime by allocating a new contiguous block
        /// and copying existing elements.
        /// </summary>
        public StaticMemoryResult ResizeVector(int newSize)
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

            return new StaticMemoryResult
            {
                CurrentSize = _vector.Length,
                EstimatedMemoryBytes = EstimatedMemoryBytes,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                BlockReferenceCode = newReference,
                BlockReallocated = previousReference != newReference,
                Message = $"Vector resized from {previousSize:N0} to {_vector.Length:N0} elements."
            };
        }

        /// <summary>
        /// Clears the current vector reference so prior data does not affect benchmarks.
        /// </summary>
        public void Clear()
        {
            _vector = Array.Empty<int>();
        }

        /// <summary>
        /// Returns a bounded preview of the array to keep the UI responsive.
        /// </summary>
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

        /// <summary>
        /// Runs an asynchronous generation and resize benchmark on a clean array without blocking the UI.
        /// </summary>
        public Task<StaticMemoryResult> RunBenchmarkAsync(int initialSize, int resizedSize)
        {
            return Task.Run(() =>
            {
                Clear();
                var stopwatch = Stopwatch.StartNew();

                GenerateVector(initialSize);
                StaticMemoryResult resizeResult = ResizeVector(resizedSize);

                stopwatch.Stop();

                return new StaticMemoryResult
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
