using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Security.Principal;

public class Scripture
{
  public Reference reference;
  public List<Word> list;
  public Scripture(string scripture, Reference reference)
  {
    list = new List<Word>();
    string [] parts = scripture.Split(" ");
  foreach (string spaceSeparatedWord in parts)
    {
      Word word = new Word(spaceSeparatedWord);
      list.Add(word);
    }
    string book = reference._book;
    int chapter = reference._chapter;
    int verse = reference._verse;
    this.reference = reference;
  }
  public void HideRandomWord(int numberToHide)
  {
      Random rand = new Random();
      for (int i = 0; i < numberToHide; i++)
      {
          int randomIndexNum = rand.Next(list.Count);
          list[randomIndexNum].Hide();
      }
      // Construct a new list with the original values but with hidden word
  }
  public string GetDisplayText()
      {
        foreach (var word in list)
        {
          word._text = word.GetDisplayText();
        }
         
        return string.Join(" ",list.Select(word => word._text));
      }
   public string GetDisplayReference()
  {
      string referenceDisplayText = reference.GetDisplayTextR();

      return referenceDisplayText;
      } 
  
 public bool IsCompletelyHidden()
{
  foreach (var word in list)
  {
      bool isHidden = true;
      foreach(char c in word._text)
        {
          if ( c != '_')
          {
            return false;
          }
        }
      if (!isHidden)
      {
        return false;
      }
  }
    return true;
  }
    
}
 

