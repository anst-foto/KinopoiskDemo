using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows;
using KinopoiskDemo.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace KinopoiskDemo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private static HttpClient HttpClient => App.HttpClient;
    [Reactive] public string? SearchText { get; set; }
    
    public ObservableCollection<Doc> Films { get; } = [];
    [Reactive] public Doc? SelectedFilm { get; set; }

    public ReactiveCommand<Unit, Unit> SearchCommand { get; }

    public MainWindowViewModel()
    {
        SearchCommand = ReactiveCommand.CreateFromTask(Search);
    }

    private async Task Search()
    {
        try
        {
            var uri = $"https://api.kinopoisk.dev/v1.4/movie?query={SearchText}";
            //HttpClient.DefaultRequestHeaders.Add("X-API-KEY", "GXMZTPV-K9T48ED-QS44YC2-S3KKGXM");
            //var films = await HttpClient.GetFromJsonAsync<Films>(uri);
            var response = await HttpClient.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show($"Забыли ключ API?");
                    return;
                }
                
                MessageBox.Show($"Error: {response.StatusCode}");
                return;
            }
            
            var films = await response.Content.ReadFromJsonAsync<Films>();
        
            Films.Clear();
            foreach (var film in films.Docs)
            {
                Films.Add(film);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }
}