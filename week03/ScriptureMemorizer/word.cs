using System;
namespace ScriptureHider
{
	// Class to represent a single word in the scripture
	class Word
	{
		private string Text { get; set; }
		public bool IsHidden { get; set; }

		public Word(string text)
		{
			Text = text;
			IsHidden = false;
		}

		public void Hide()
		{
			IsHidden = true;
		}

		public override string ToString()
		{
			return IsHidden ? new string('_', Text.Length) : Text;
		}
	}
}