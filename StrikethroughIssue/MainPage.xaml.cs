namespace StrikethroughIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SampleViewModel();
        }
    }

}
