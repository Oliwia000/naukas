namespace naukas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

        
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;


        }
    }

}
