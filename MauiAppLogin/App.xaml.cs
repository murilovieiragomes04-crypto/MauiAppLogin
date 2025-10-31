namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }


        protected override Window Createwindow(IActivationState ActivationState)
        {
            var window = base.CreateWindow(ActivationState);

            window.Height = 700;
            window.Width = 400;

            return window;
        }      
                

    }
}
