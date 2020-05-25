using System.Drawing;

namespace SharpBot
{
    public class FinalStateValue
    {
        string IText;
        string ILink;
        Image ILogo;

        public FinalStateValue(string Text, string Link, string Logo)
        {
            this.IText = Text;
            this.ILink = Link;
            this.ILogo = Image.FromFile("../../../resources/recomendations/" + Logo + ".png");
        }

        public string Text
        {
            get { return this.IText; }
        }

        public string Link
        {
            get { return this.ILink; }
        }

        public Image Logo
        {
            get { return this.ILogo; }
        }
    }
}
