namespace PrimeFuncPack.UnitTest.Data.Tests.TestData

open Xunit
open PrimeFuncPack.UnitTest
open TestHelper

module DataRecordTypeTest =

    [<Fact>]
    let ``TestData.PlusFifteenIdSomeStringNameRecord should be with the id is 15 and the name is the some string``() =
        let expected = RecordType(Id = TestData.PlusFifteen, Name = TestData.SomeString)
        TestData.PlusFifteenIdSomeStringNameRecord |> shouldBeDeepEqual expected

    [<Fact>]
    let ``TestData.PlusFifteenIdLowerSomeStringNameRecord should be with the id is 15 and the name is the some string``() =
        let expected = RecordType(Id = TestData.PlusFifteen, Name = TestData.LowerSomeString)
        TestData.PlusFifteenIdLowerSomeStringNameRecord |> shouldBeDeepEqual expected

    [<Fact>]
    let ``TestData.MinusFifteenIdSomeStringNameRecord should be with the id is -15 and the name is the some string``() =
        let expected = RecordType(Id = TestData.MinusFifteen, Name = TestData.SomeString)
        TestData.MinusFifteenIdSomeStringNameRecord |> shouldBeDeepEqual expected

    [<Fact>]
    let ``TestData.MinusFifteenIdNullNameRecord should be with the id is -15 and the name is null``() =
        let expected = RecordType(Id = TestData.MinusFifteen)
        TestData.MinusFifteenIdNullNameRecord |> shouldBeDeepEqual expected

    [<Fact>]
    let ``TestData.ZeroIdNullNameRecord should be with the id is 0 and the name is null``() =
        let expected = RecordType()
        TestData.ZeroIdNullNameRecord |> shouldBeDeepEqual expected