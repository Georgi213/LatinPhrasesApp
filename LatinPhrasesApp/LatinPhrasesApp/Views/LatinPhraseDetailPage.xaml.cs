using LatinPhrasesApp.Models;
using LatinPhrasesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatinPhrasesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LatinPhraseDetailPage : ContentPage
    {
        private LatinPhraseDetailViewModel _viewModel;

        public LatinPhraseDetailPage(LatinPhrase latinPhrase)
        {
            InitializeComponent();
            BindingContext = _viewModel = new LatinPhraseDetailViewModel(latinPhrase);
        }
    }

}