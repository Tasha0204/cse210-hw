using System; 

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split();
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = GetVisibleWords();
        int actualCountToHide = Math.Min(numberToHide, visibleWords.Count);

        Random random = new Random();
        int wordsHidden = 0;
        while (visibleWords.Count > 0  & wordsHidden < actualCountToHide)
        {
        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hide();
        visibleWords.RemoveAt(randomIndex);
        wordsHidden++;
    }
    }
    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                visibleWords.Add(word);
        }
        return visibleWords;
    }
    public string GetDisplayText()
    {
    
        string referenceString = _reference.GetDisplayText(); 
        
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " "; 
        }
        
        return $"{referenceString}: {scriptureText.Trim()}";
    }
    public bool IsCompletelyHidden()
    {
        return GetVisibleWords().Count == 0;
    }
}