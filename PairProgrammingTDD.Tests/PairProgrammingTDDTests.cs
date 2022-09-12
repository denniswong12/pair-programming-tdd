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

    [TestCase("how are you", new String[] { "are", "you", "how" })]
    [TestCase("paz is a great programmer", new String[] { "a", "programmer", "is", "great", "paz" })]
    [TestCase("Today is going to be good", new String[] { "good", "be", "going", "to", "is", "Today" })]
    [TestCase("I'm learning tdd", new String[] {"tdd", "learning", "I'm"})]
    [TestCase("I enjoy being with techreturners learning c sharp", new String[] {"c", "being", "learning", "with", "I", "sharp", "techreturners", "enjoy" })]
    public void Given_A_String_Of_Words_Return_An_Array_Of_Words_Alphabetically_Sorted_By_Last_Letter(string stringOfWords, string[] expectedWordsArray)
    {
        CollectionAssert.AreEqual(expectedWordsArray, _wordArranger.SortAlphabeticallyByLastLetter(stringOfWords));
    }
}