namespace PairProgrammingTDD;

public class WordArranger
{
    public string[] SortAlphabeticallyByLastLetter(string stringOfWords)
    {
        List<string> splitedWordsList = stringOfWords.Split(" ").ToList();
        splitedWordsList.Sort((l, r) => new string(l.Reverse().ToArray()).CompareTo(new string(r.Reverse().ToArray())));
        return splitedWordsList.ToArray();
    }
}
