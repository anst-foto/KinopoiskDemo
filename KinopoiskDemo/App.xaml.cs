using System.Net.Http;
using System.Windows;

namespace KinopoiskDemo;


public partial class App : Application
{
    public static HttpClient HttpClient = new HttpClient(); 
}