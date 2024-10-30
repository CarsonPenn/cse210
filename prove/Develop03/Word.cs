using System;

class Word
{
    private Scripture _scripture;
    private List<string> _scriptureTextList;
    private int _totalWordsRemoved = 0;

    public Word(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        _scriptureTextList = _scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = 3;
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, _scriptureTextList.Count());
            if (_scriptureTextList[rndIndex].Contains('_') == false)
            {
                _scriptureTextList[rndIndex] = new string('_', _scriptureTextList[rndIndex].Length);
                wordsRemoved++;
                _totalWordsRemoved++;

                if ((_scriptureTextList.Count() - numWordsToRemove) <= _totalWordsRemoved && _totalWordsRemoved < (_scriptureTextList.Count() + 1))
                {
                    wordsRemoved = 3;
                }
            }

        } while (wordsRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(" ", _scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retValue = false;

        foreach (string word in _scriptureTextList)
        {
            if (word.Contains("_") == false)
            {
                retValue = true;
                break;
            }
        }

        return retValue;
    }
}

// I knew i would need somwhat complicated loops so i used some youtube examples on how to use, while, foreach, and if. 
// Chatgpt taught me some examples of how to set up the loops 
