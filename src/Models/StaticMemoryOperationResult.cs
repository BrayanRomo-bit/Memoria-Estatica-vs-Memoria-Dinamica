namespace MemoryComparison.Models
{
    public sealed class StaticMemoryOperationResult
    {
        public int CurrentSize { get; init; }
        public long EstimatedMemoryBytes { get; init; }
        public double ElapsedMilliseconds { get; init; }
        public int BlockReferenceCode { get; init; }
        public bool BlockReallocated { get; init; }
        public string Message { get; init; } = string.Empty;
    }
}
