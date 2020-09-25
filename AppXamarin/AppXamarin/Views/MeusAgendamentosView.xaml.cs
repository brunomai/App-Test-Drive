using AppXamarin.Models;
using AppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeusAgendamentosView : ContentPage
    {
        public MeusAgendamentosView()
        {
            InitializeComponent();

            this.BindingContext = new MeusAgendamentosViewModel();
            
        }
    }
}