using System;


class Scripture{ 
    private string _scriptureText;
    private Reference _scriptureReference;

    public Scripture (Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        _scriptureText = scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", _scriptureText);
    }

}
// goal compile the scripture text 
// Steps:
// 1. create new class
// 2 create the methods
// 3 have the Scritpture class take the Reference and tie it together with the scripture text
// 4 convert the scripture text to a string
// 