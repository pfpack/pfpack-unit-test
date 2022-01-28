namespace PrimeFuncPack.UnitTest.Data.Tests

open Xunit
open PrimeFuncPack.UnitTest
open TestHelper

module Int32Test =

    [<Theory>]
    [<InlineData(TestData.MinusFifteen, -15)>]
    [<InlineData(TestData.MinusOne, -1)>]
    [<InlineData(TestData.Zero, 0)>]
    [<InlineData(TestData.One, 1)>]
    [<InlineData(TestData.PlusFifteen, 15)>]
    let ``Int32 test data value sould be expected`` (testDataValue: int) expected =
        testDataValue |> shouldBeEqual expected