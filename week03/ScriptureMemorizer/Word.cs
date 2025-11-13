using System;
public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        this._text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (IsHidden())
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}