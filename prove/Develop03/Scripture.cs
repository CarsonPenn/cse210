using System;

// getting and storing the Text of a scripture
public class Scripture{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public string Text { get; set; }

    public Scripture(string book, int chapter, int verse, string text)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{Verse} - {Text}";
    }
}
