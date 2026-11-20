namespace MemoryComparison.Models
{
    public sealed class DynamicMemoryOperationResult
    {
        public int ActiveInstances { get; init; }
        public long HeapMemoryBytes { get; init; }
        public long MemoryDeltaBytes { get; init; }
        public double ElapsedMilliseconds { get; init; }
        public string Message { get; init; } = string.Empty;
    }
}
