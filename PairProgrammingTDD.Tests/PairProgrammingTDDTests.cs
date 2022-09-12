using FluentAssertions;

namespace PairProgrammingTDD.Tests;

public class Tests
{
    private WordArranger _wordArranger;

    [SetUp]
    public void Setup()
    {
        _wordArranger = new WordArranger();
    }

    [Test]
    public void Given_A_String_Of_Words_Return_An_Array_Of_Words_Alphabetically_Sorted_By_Last_Letter()
    {
        _wordArranger.SortAlphabeticallyByLastLetter("how are you").Should().Be("are you how");
    }
}