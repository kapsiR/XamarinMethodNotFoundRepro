using Xamarin.Forms;

namespace MethodNotFoundRepro.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            TestBug();
        }

        private static void TestBug()
        {
            System.Drawing.Color test = Color.Black;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
