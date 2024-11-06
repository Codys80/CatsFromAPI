using System.Net;
using System.Text.Json;
//using static Android.Provider.Telephony.Mms;

namespace CatsFromApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public string createCatText(string input)
        {
            return $"https://cataas.com/cat/says/{input}?fontSize=170&fontColor=green";
        }
        private void OnCatClicked(object sender, EventArgs e)
        {
            string nazwa = (sender as Button).Text;
            switch (nazwa)
            {
                case "Kliknij żeby kot 1":
                    displayCat1.Source = "https://cataas.com/cat";
                    break;
                case "Kliknij żeby kot 2":
                    displayCat2.Source = "https://cataas.com/cat";
                    break;
                case "Kliknij żeby kot 3":
                    displayCat3.Source = "https://cataas.com/cat";
                    break;
                case "Kliknij żeby kot TEXT":
                    displayCatText.Source = createCatText(KotEntry.Text);
                    break;
            }
        }
    }

}
