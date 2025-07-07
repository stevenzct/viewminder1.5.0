namespace viewminder1
{
    public class TextEventArgs
    {
        private string text;

        public TextEventArgs(string text)
        {
            this.text = text;
        }

        public string Text { get; internal set; }
    }
}