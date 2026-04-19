namespace PrimeFuncPack.UnitTest.Data.Tests

open Xunit

module internal TestHelper =

    let internal shouldBeEmpty collection =
        Assert.Empty collection

    let internal shouldBeTheSame expected actual =
        Assert.Same(expected = expected, actual = actual)

    let internal shouldBeEqual<'t> (expected : 't) (actual : 't) =
        Assert.Equal<'t>(expected, actual)

    let internal shouldBeEqualString (expected: string) (actual: string) =
        Assert.Equal(expected = expected, actual = actual, ignoreCase = false)

    let internal shouldBeDeepEqual expected actual =
        Assert.Equivalent(expected = expected, actual = actual)
