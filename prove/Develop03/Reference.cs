using System;
using System.Runtime.CompilerServices;

// Getting the Book, Chapter and Verse of the scripture. 
public class Reference
{
    private string _book, _chapter, _startVerse, _endVerse;

    public Reference(string book, string chapter, string startVerse, string endVerse = "")
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;

        _endVerse = string.IsNullOrEmpty(endVerse) ? startVerse : endVerse;
    }

    public string toString()
    {
        if (_startVerse == _endVerse)
        {
            return string.Format("{0} {1}:{2}", _book, _chapter, _startVerse);
        }
        else
        {
            return string.Format("{0} {1}:{2}-{3}", _book, _chapter, _startVerse, _endVerse);
        }
        // return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
    }




}

// goal compile the scriptture reference
// steps
// 1 get down the attributes
// 2 create a constuctor that will build the reference
// later revised it to take a first and last verse


// notes
// chatgpt taught me how to create the first and last verse, and how to defualt it to go to the last verse.

