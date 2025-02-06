namespace CapitecAssign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GlobalOneHomePage();
            MainPage = new NavigationPage(new DashboardPage());
        }
    }
}
