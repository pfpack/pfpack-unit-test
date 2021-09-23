namespace PrimeFuncPack.UnitTest.Data.Tests.TestData

open Xunit
open PrimeFuncPack.UnitTest
open TestHelper

module DataRefTypeTest =

    [<Fact>]
    let ``TestData.PlusFifteenIdRefType should be with the id is 15``() =
        let expected = RefType(Id = TestData.PlusFifteen)
        TestData.PlusFifteenIdRefType |> shouldDeepEqual (new RefType(Id = TestData.PlusFifteen))

    [<Fact>]
    let ``Call TestData.PlusFifteenIdRefType two times. Expect the results are same``() =
        TestData.PlusFifteenIdRefType |> shouldBeTheSame TestData.PlusFifteenIdRefType

    [<Fact>]
    let ZeroIdRefType_ExpectRefTypeIdIsZero() =
        let expected = RefType(Id = TestData.Zero)
        TestData.ZeroIdRefType |> shouldDeepEqual expected

    [<Fact>]
    let ZeroIdRefTypeTwoTimes_ExpectSameValues() =
        TestData.ZeroIdRefType |> shouldBeTheSame TestData.ZeroIdRefType


    [<Fact>]
    let MinusFifteenIdRefType_ExpectRefTypeIdIsMinusFifteen() =
        let expected = RefType(Id = TestData.MinusFifteen)
        TestData.MinusFifteenIdRefType |> shouldDeepEqual expected

    [<Fact>]
    let MinusFifteenIdRefTypeTwoTimes_ExpectSameValues() =
        TestData.MinusFifteenIdRefType |> shouldBeTheSame TestData.MinusFifteenIdRefType
