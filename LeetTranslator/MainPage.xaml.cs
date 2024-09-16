namespace LeetTranslator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTranslateClicked(object sender, EventArgs e)
        {
            string input = inputEntry.Text;
            double degree = degreeSlider.Value;

            LeetTranslator translator = new LeetTranslator();
            string output = translator.ToLeet(input, degree);

            outputLabel.Text = output;
        }

        private void OnDegreeSliderChanged(object sender, ValueChangedEventArgs e)
        {
            degreeLabel.Text = degreeSlider.Value.ToString("N0");
        }
    }

}
