namespace PrimeFuncPack.UnitTest.Data.Tests.TestData

open Xunit
open PrimeFuncPack.UnitTest
open TestHelper

module StringTest =

    let private toString chars =
        new string([| for c in chars -> c |])

    let private createString (char: char) count =
        new string([| for _ = 1 to count do char |])

    let private toLowerInvariant (text: string) =
        text.ToLowerInvariant()

    let private toUpperInvariant (text: string) =
        text.ToUpperInvariant()

    [<Fact>]
    let ``TestData.EmptyString sould be the empty string``() =
        TestData.EmptyString |> shouldBeEmpty

    [<Fact>]
    let ``TestData.WhiteSpaceString sould be the white space string``() =
        let expected = createString ' ' 1
        TestData.WhiteSpaceString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.TwoWhiteSpacesString sould be the two white spaces string``() =
        let expected = createString ' ' 2
        TestData.TwoWhiteSpacesString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.ThreeWhiteSpacesString sould be the three white spaces string``() =
        let expected = createString ' ' 3
        TestData.ThreeWhiteSpacesString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.TabString sould be the tab string``() =
        let expected = createString '\t' 1
        TestData.TabString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.TwoTabsString sould be two the tabs string``() =
        let expected = createString '\t' 2
        TestData.TwoTabsString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.MixedWhiteSpacesString sould be the mixed white spaces string``() =
        let expected = [| '\t'; '\t'; ' ' |] |> toString
        TestData.MixedWhiteSpacesString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.SomeString sould be the some string``() =
        TestData.SomeString |> shouldBeEqualString "Some String"

    [<Fact>]
    let ``TestData.LowerSomeString sould be the lower some string``() =
        let expected = TestData.SomeString |> toLowerInvariant
        TestData.LowerSomeString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.UpperSomeString sould be the upper some string``() =
        let expected = TestData.SomeString |> toUpperInvariant
        TestData.UpperSomeString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.AnotherString sould be the other string``() =
        TestData.AnotherString |> shouldBeEqualString "Another string"

    [<Fact>]
    let ``TestData.LowerAnotherString sould be the lower other string``() =
        let expected = TestData.AnotherString |> toLowerInvariant
        TestData.LowerAnotherString |> shouldBeEqualString expected

    [<Fact>]
    let ``TestData.UpperAnotherString sould be the upper other string``() =
        let expected = TestData.AnotherString |> toUpperInvariant
        TestData.UpperAnotherString |> shouldBeEqualString expected