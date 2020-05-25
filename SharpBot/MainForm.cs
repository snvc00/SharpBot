using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SharpBot
{
    public partial class MainForm : Form
    {
        Dictionary<string, FinalStateValue> FinalStateTable;
        Dictionary<string, State> StateTable;
        FinalStateValue FinalState;
        State CurrentState;
        string Word;

        public MainForm()
        {
            InitializeComponent();
            InitializeStatesTable();
            InitializeFinalStatesTable();
            InitializeTransitionsTable();

            this.Word = "";
            this.CurrentState = StateTable["q0"];
        }

        public void InitializeTransitionsTable()
        {
            Dictionary<char, string> TransitionTable = new Dictionary<char, string>();
            string id;

            foreach (string transition in File.ReadLines("../../../resources/state-transitions.txt"))
            {
                // transition string format: state_id:nextStateForInput0|nextStateForInput1|nextStateForInput2

                id = transition.Split(':')[0];
                TransitionTable['0'] = transition.Split(':')[1].Split('|')[0];
                TransitionTable['1'] = transition.Split(':')[1].Split('|')[1];
                TransitionTable['2'] = transition.Split(':')[1].Split('|')[2];

                StateTable[id].SetStateTransitions(new Dictionary<char, string>(TransitionTable));
            }
        }

        public void InitializeFinalStatesTable()
        {
            FinalStateTable = new Dictionary<string, FinalStateValue>();
            string id, text, link, logo;

            foreach (string value in File.ReadLines("../../../resources/final-state-values.txt"))
            {
                // value string format: id|text|link|logo

                id = value.Split('|')[0];
                text = value.Split('|')[1];
                link = value.Split('|')[2];
                logo = value.Split('|')[3];

                FinalStateTable[id] = new FinalStateValue(text, link, logo);
            }
        }

        public void InitializeStatesTable()
        {
            StateTable = new Dictionary<string, State>();
            string id, textbutton0, textbutton1, textbutton2, botdialog;

            foreach (string value in File.ReadLines("../../../resources/automata-states.txt"))
            {
                // value string format: id|textbutton0|textbutton1|textbutton2|botdialog

                id = value.Split('|')[0];
                textbutton0 = value.Split('|')[1];
                textbutton1 = value.Split('|')[2];
                textbutton2 = value.Split('|')[3];
                botdialog = value.Split('|')[4];

                StateTable[id] = new State(textbutton0, textbutton1, textbutton2, botdialog);
            }
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            this.Word = "";
            this.CurrentState = StateTable["q0"];
            this.FinalState = null;

            if (PictureBox_Logo.Visible)
                PictureBox_Logo.Visible = false;

            if (LinkLabel_RecomendationText.Visible)
                LinkLabel_RecomendationText.Visible = false;

            Button_Append0.Enabled = true;
            Button_Append1.Enabled = true;
            Button_Append2.Enabled = true;

            Label_BotStatus.Text = "Trabajando";
            PictureBox_BotStatus.Image = Image.FromFile("../../../resources/mainform/processing.png");

            UpdateWindowByCurrentState();
        }

        private void Button_Append0_Click(object sender, EventArgs e)
        {
            this.Word += '0';

            if (Word.Length < 3)
            {
                CurrentState = GetNextState('0');
                UpdateWindowByCurrentState();
            }
            else
            {
                FinalState = FinalStateTable[Word];
                UpdateWindowByFinalState();
            }
        }

        private void Button_Append1_Click(object sender, EventArgs e)
        {
            this.Word += '1';

            if (Word.Length < 3)
            {
                CurrentState = GetNextState('1');
                UpdateWindowByCurrentState();
            }
            else
            {
                FinalState = FinalStateTable[Word];
                UpdateWindowByFinalState();
            }
        }

        private void Button_Append2_Click(object sender, EventArgs e)
        {
            this.Word += '2';

            if (Word.Length < 3)
            {
                CurrentState = GetNextState('2');
                UpdateWindowByCurrentState();
            }
            else
            {
                FinalState = FinalStateTable[Word];
                UpdateWindowByFinalState();
            }
        }

        private void LinkLabel_RecomendationText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FinalState != null)
                Process.Start(FinalState.Link);
        }

        private void PictureBox_Logo_Click(object sender, EventArgs e)
        {
            if (FinalState != null)
                Process.Start(FinalState.Link);
        }

        private void UpdateWindowByCurrentState()
        {
            Button_Append0.Text = CurrentState.TextButton0;
            Button_Append1.Text = CurrentState.TextButton1;
            Button_Append2.Text = CurrentState.TextButton2;
            TextBox_BotDialog.Text = CurrentState.BotDialog;
            this.Refresh();
        }

        private void UpdateWindowByFinalState()
        {
            Button_Append0.Enabled = false;
            Button_Append1.Enabled = false;
            Button_Append2.Enabled = false;

            LinkLabel_RecomendationText.Text = FinalState.Text;
            PictureBox_Logo.Image = FinalState.Logo;

            LinkLabel_RecomendationText.Show();
            PictureBox_Logo.Show();

            PictureBox_BotStatus.Image = Image.FromFile("../../../resources/mainform/tick.png");
            Label_BotStatus.Text = "Completado";
            TextBox_BotDialog.Text = "¡Termine! Espero la recomendación sea de tu agrado y te haya dado una idea de que hacer en internet, ¡hasta la próxima! :)";
        }

        private State GetNextState(char input)
        {
            return StateTable[CurrentState.StateTransitionsTable[input]];
        }
    }
}
