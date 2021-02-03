#nullable enable

using static System.FormattableString;

namespace PrimeFuncPack.UnitTest
{
    public sealed record RecordType
    {
        public int Id { get; set; }

        public string? Name { get; set; }        
        
        public override string? ToString()
            =>
            Invariant($"{nameof(RefType)}.{Id}: '{Name}'");
    }
}
