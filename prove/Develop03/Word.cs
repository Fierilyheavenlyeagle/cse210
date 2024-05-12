using System.Dynamic;
using System.Net;
using System.Security.Cryptography;

public class Word
{
    public string _text;
    public bool _isHidden;

    public Word(string text)
    {
      _text = text;
    }
    public void Hide()
    {
      _isHidden = true;
    }
    public void show()
    {
      _isHidden = false;
    }
    public bool IsHidden()
    {
      return _isHidden;
    }  
    public string GetDisplayText()
    {
        if (_isHidden)
        {
          return new string('_',_text.Length);
        }
        else
        {
          return _text;
        }
    }
}