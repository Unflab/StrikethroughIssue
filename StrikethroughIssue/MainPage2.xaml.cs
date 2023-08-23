using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace StrikethroughIssue
{
    public partial class MainPage2 : ContentPage
    {
        int count = 0;
        public MainPage2()
        {
            InitializeComponent();
        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                MyLabel.Text = $"Clicked {count} time";
            else
                MyLabel.Text = $"Clicked {count} times";
        }

        private void MyCheck_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            MyLabel.TextDecorations = MyCheck.IsChecked ? TextDecorations.Strikethrough : TextDecorations.Underline;
            Debug.WriteLine(MyLabel.TextDecorations.ToString());
        }
    }

}
