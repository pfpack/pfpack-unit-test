namespace PrimeFuncPack.UnitTest.Data.Tests

open Xunit
open PrimeFuncPack.UnitTest
open TestHelper

module DataRefTypeTest =

    [<Fact>]
    let ``TestData.PlusFifteenIdRefType should be the id is 15``() =
        let expected = RefType(Id = TestData.PlusFifteen)
        TestData.PlusFifteenIdRefType |> shouldBeDeepEqual expected

    [<Fact>]
    let ``Call TestData.PlusFifteenIdRefType two times. Expect the results are the same``() =
        TestData.PlusFifteenIdRefType |> shouldBeTheSame TestData.PlusFifteenIdRefType

    [<Fact>]
    let ``TestData.ZeroIdRefType should be the id is 0``() =
        let expected = RefType(Id = TestData.Zero)
        TestData.ZeroIdRefType |> shouldBeDeepEqual expected

    [<Fact>]
    let ``Call TestData.ZeroIdRefType two times. Expect the results are the same``() =
        TestData.ZeroIdRefType |> shouldBeTheSame TestData.ZeroIdRefType


    [<Fact>]
    let ``TestData.MinusFifteenIdRefType should be the id is -15``() =
        let expected = RefType(Id = TestData.MinusFifteen)
        TestData.MinusFifteenIdRefType |> shouldBeDeepEqual expected

    [<Fact>]
    let ``Call TestData.MinusFifteenIdRefType two times. Expect the results are the same``() =
        TestData.MinusFifteenIdRefType |> shouldBeTheSame TestData.MinusFifteenIdRefType
