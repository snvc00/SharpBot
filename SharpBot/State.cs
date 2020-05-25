using System.Collections.Generic;

namespace SharpBot
{
    public class State
    {
        string ITextButton0;
        string ITextButton1;
        string ITextButton2;
        string IBotDialog;
        Dictionary<char, string> IStateTransitionsTable;

        public State(string TextButton0, string TextButton1, string TextButton2, string IBotDialog)
        {
            this.ITextButton0 = TextButton0;
            this.ITextButton1 = TextButton1;
            this.ITextButton2 = TextButton2;
            this.IBotDialog = IBotDialog;
        }

        public string TextButton0
        {
            get { return this.ITextButton0; }
        }

        public string TextButton1
        {
            get { return this.ITextButton1; }
        }

        public string TextButton2
        {
            get { return this.ITextButton2; }
        }

        public string BotDialog
        {
            get { return this.IBotDialog; }
        }

        public Dictionary<char, string> StateTransitionsTable
        {
            get { return this.IStateTransitionsTable; }
        }

        public void SetStateTransitions(Dictionary<char, string> StateTransitionsTable)
        {
            this.IStateTransitionsTable = StateTransitionsTable;
        }
    }
}
