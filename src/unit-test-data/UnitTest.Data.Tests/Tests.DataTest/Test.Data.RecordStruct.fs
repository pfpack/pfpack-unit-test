namespace PrimeFuncPack.UnitTest.Data.Tests.TestData

open Xunit
open PrimeFuncPack.UnitTest
open TestHelper

module DataRecordStructTest =

    [<Fact>]
    let ``TestData.SomeTextRecordStruct should be the text is the some string``() =
        let expected = RecordStruct(Text = TestData.SomeString)
        TestData.SomeTextRecordStruct |> shouldBeEqual expected

    [<Fact>]
    let ``TestData.UpperSomeTextRecordStruct should be the text is the upper some string``() =
        let expected = RecordStruct(Text = TestData.UpperSomeString)
        TestData.UpperSomeTextRecordStruct |> shouldBeEqual expected

    [<Fact>]
    let ``TestData.AnotherTextRecordStruct should be the text is the other string``() =
        let expected = RecordStruct(Text = TestData.AnotherString)
        TestData.AnotherTextRecordStruct |> shouldBeEqual expected

    [<Fact>]
    let ``TestData.UpperAnotherTextRecordStruct should be the text is the upper other string``() =
        let expected = RecordStruct(Text = TestData.UpperAnotherString)
        TestData.UpperAnotherTextRecordStruct |> shouldBeEqual expected