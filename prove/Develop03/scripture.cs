
class Scripture
{
    private Reference _reference;
    private string[] _verses;
    private bool[][] _hiddenWords;

    public Scripture(Reference reference, string[] verses)
    {
        this._reference = reference;
        this._verses = verses;
        this._hiddenWords = new bool[verses.Length][];
        for (int i = 0; i < verses.Length; i++)
        {
            _hiddenWords[i] = new bool[verses[i].Split(' ').Length];
        }
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void SetReference(Reference reference)
    {
        this._reference = reference;
    }

    public string[] GetVerses()
    {
        return _verses;
    }

    public void SetVerses(string[] verses)
    {
        this._verses = verses;
    }
    public void HideWord(int verseIndex, int wordIndex)
    {
        _hiddenWords[verseIndex][wordIndex] = true;
    }

    public bool IsWordHidden(int verseIndex, int wordIndex)
    {
        return _hiddenWords[verseIndex][wordIndex];
    }

    public string GetRenderedText()
    {
        string[] words;
        string renderedText = "";
        for (int i = 0; i < _verses.Length; i++)
        {
            words = _verses[i].Split(' ');
            for (int j = 0; j < words.Length; j++)
            {
                if (_hiddenWords[i][j])
                {
                    renderedText += "_____ ";
                }
                else
                {
                    renderedText += words[j] + " ";
                }
            }
            renderedText += "\n";
        }
        return renderedText;
    }
}