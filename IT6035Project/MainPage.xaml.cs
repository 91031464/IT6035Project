using Xamarin.Forms;
using System;

namespace IT6035Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //public object OutputBox { get; private set; }

        void Merchandiser_Button_Clicked(Object sender, EventArgs e)
        {
            OutputBox.Text = "The Merchandiser button is clicked";
        }

        void Supervisor_Button_Clicked(Object sender, EventArgs e)
        {
            OutputBox.Text = "The Supervisor buttom is clicked";
        }

        //void Merchandiser_Button_Clicked(System.Object sender, System.EventArgs e)
        //{
        //}        //void Button_Clicked(System.Object sender, System.EventArgs e)
        //{
        //}

        //void Button_Clicked_1(System.Object sender, System.EventArgs e)
        //{
        //}

        //void MerchandiserButton_Clicked(Object sender, EventArgs e)
        //{
        //    OutputBox = "The Merchandiser button is clicked";
        //}

        //void SupervisorButton_Clicked(Object sender, EventArgs e)
        //{
        //    OutputBox = "The Supervisor buttom is clicked";
        //}
    }
}
