class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        this.hidden = false;
    }

    public string GetText()
    {
        return text;
    }

    public void SetText(string text)
    {
        this.text = text;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public void SetHidden(bool hidden)
    {
        this.hidden = hidden;
    }
}
