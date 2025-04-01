using System;

namespace ScriptureHider
{
	   // Class to represent a scripture reference
    class Reference
    {
        private string Book { get; set; }
        private string Chapter { get; set; }
        private string Verse { get; set; }

        public Reference(string book, string chapter, string verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }
}