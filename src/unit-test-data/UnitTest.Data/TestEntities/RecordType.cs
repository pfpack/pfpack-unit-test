using static System.FormattableString;

namespace PrimeFuncPack.UnitTest;

public sealed record class RecordType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public override string? ToString()
        =>
        Invariant($"{nameof(RefType)}.{Id}: '{Name}'");
}