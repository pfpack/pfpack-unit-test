namespace PrimeFuncPack.UnitTest.Data.Tests.TestData

open Xunit
open PrimeFuncPack.UnitTest
open TestHelper

module DataStructTypeTest =

    [<Fact>]
    let ``TestData.SomeTextStructType should be with the text is the some string``() =
        let expected = StructType(Text = TestData.SomeString)
        TestData.SomeTextStructType |> shouldBeEqual expected

    [<Fact>]
    let ``TestData.LowerSomeTextStructType should be with the text is the lower some string``() =
        let expected = StructType(Text = TestData.LowerSomeString)
        TestData.LowerSomeTextStructType |> shouldBeEqual expected

    [<Fact>]
    let ``TestData.AnotherTextStructType should be with the text is the other string``() =
        let expected = StructType(Text = TestData.AnotherString)
        TestData.AnotherTextStructType |> shouldBeEqual expected

    [<Fact>]
    let ``TestData.UpperAnotherTextStructType should be with the text is the upper other string``() =
        let expected = StructType(Text = TestData.UpperAnotherString)
        TestData.UpperAnotherTextStructType |> shouldBeEqual expected

    [<Fact>]
    let ``TestData.NullTextStructType should be with the text is null``() =
        let expected = StructType()
        TestData.NullTextStructType |> shouldBeEqual expected

