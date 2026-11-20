using System.Runtime.CompilerServices;

namespace Memoria_Estatica
{
    public sealed class HeapObject
    {
        public int Id { get; }
        public string Label { get; set; }
        public int Value { get; set; }
        public byte[] Payload { get; }
        public HeapObject? Next { get; set; }

        public int ReferenceCode => RuntimeHelpers.GetHashCode(this);

        public HeapObject(int id, string label, int value, int payloadSizeBytes)
        {
            Id = id;
            Label = label;
            Value = value;
            Payload = payloadSizeBytes > 0 ? new byte[payloadSizeBytes] : Array.Empty<byte>();
        }

        public override string ToString()
        {
            string nextRef = Next != null ? $"0x{Next.ReferenceCode:X8}" : "null";
            return $"ID:{Id} | Ref:0x{ReferenceCode:X8} | Value:{Value} | Payload:{Payload.Length}B | Next->{nextRef}";
        }
    }
}
