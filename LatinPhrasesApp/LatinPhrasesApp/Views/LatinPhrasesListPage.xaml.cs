using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatinPhrasesApp.Models;
using LatinPhrasesApp.Services;
using LatinPhrasesApp.ViewModels;
using LatinPhrasesApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatinPhrasesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LatinPhrasesListPage : ContentPage
    {
        private readonly LatinPhrasesListViewModel _viewModel;

        public LatinPhrasesListPage(Author selectedAuthor)
        {
            InitializeComponent();
            var dataService = App.ServiceProvider.GetService<IDataService>();
            BindingContext = _viewModel = new LatinPhrasesListViewModel(selectedAuthor, dataService);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadLatinPhrasesCommand.Execute(null);
        }
    }
}