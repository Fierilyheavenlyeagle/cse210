using System.Dynamic;
using System.Net;
using System.Security.Cryptography;

public class Reference
{
  public string _book;
  public int _chapter;
  public int _verse ;  
 
 public Reference(string book, int chapter, int verse)
 {
  _book = book;
  _chapter = chapter;
  _verse = verse;
 }
 public string GetDisplayTextR()
 {
  return $"{_book} {_chapter} : {_verse}";
 }
 
}

