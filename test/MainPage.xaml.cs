namespace JiuLing.Controls.Maui.Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Image_SizeChanged(object sender, EventArgs e)
        {
            blurSlider.Value = 79;
        }
    }
}