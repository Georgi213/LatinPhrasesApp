using LatinPhrasesApp.Models;
using LatinPhrasesApp.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace LatinPhrasesApp.ViewModels
{
    public class LatinPhrasesListViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        private Author _author;

        public ObservableCollection<LatinPhrase> LatinPhrases { get; set; }
        public Command LoadLatinPhrasesCommand { get; set; }

        public LatinPhrasesListViewModel(Author author, IDataService dataService)
        {
            _author = author;
            _dataService = dataService;
            LatinPhrases = new ObservableCollection<LatinPhrase>();
            LoadLatinPhrasesCommand = new Command(async () => await LoadLatinPhrasesAsync());
        }

        private async Task LoadLatinPhrasesAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                LatinPhrases.Clear();
                var phrases = await _dataService.GetLatinPhrasesByAuthorIdAsync(_author.Id);
                foreach (var phrase in phrases)
                {
                    LatinPhrases.Add(phrase);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
}  }
