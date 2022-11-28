namespace MauiÜbung
{
    internal class WorkItem
    {
        
        
        private string labelText;
        public string LabelText
        {
            get { return labelText; }
        }

        private string buttonText;
        public string ButtonText
        {
            get { return buttonText; }
        }

        public WorkItem()
        {
            labelText = "Hallo aus einem Label";
            buttonText = "Hallo aus einem Button";
        }

    }
}
