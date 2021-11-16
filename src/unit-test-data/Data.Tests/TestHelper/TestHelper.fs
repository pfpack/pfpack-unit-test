namespace PrimeFuncPack.UnitTest.Data.Tests.TestData

open DeepEqual.Syntax
open Xunit

module internal TestHelper =

    let internal shouldBeEmpty collection =
        Assert.Empty collection

    let internal shouldBeTheSame expected actual =
        Assert.Same(expected = expected, actual = actual)

    let internal shouldBeEqual<'t> (expected : 't) actual =
        Assert.Equal(expected = expected, actual = actual)

    let internal shouldBeEqualString expected actual =
        Assert.Equal(expected = expected, actual = actual, ignoreCase = false)

    let internal shouldBeDeepEqual expected actual =
        actual.ShouldDeepEqual(expected)