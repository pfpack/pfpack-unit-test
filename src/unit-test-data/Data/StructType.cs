#nullable enable

using static System.FormattableString;

namespace PrimeFuncPack.UnitTest
{
    public struct StructType
    {
        public string? Text { get; set; }

        public override string? ToString()
            =>
            Invariant($"{nameof(StructType)}: '{Text}'");
    }
}
