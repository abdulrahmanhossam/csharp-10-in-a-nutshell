namespace CSharp_10_in_a_Nutshell.CP3.Indexers;

public class Sentence
{
    string[] words = "The quick brown fox".Split();

    // Indexer 
    public string this[int wordNum]
    {
        get { return words[wordNum]; }  // reading
        set { words[wordNum] = value; }  // Write
    }
}