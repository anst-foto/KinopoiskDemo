// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KinopoiskDemo.Models;

public class Country
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Doc
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("alternativeName")]
        public string AlternativeName { get; set; }

        [JsonPropertyName("enName")]
        public object EnName { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("typeNumber")]
        public int TypeNumber { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("shortDescription")]
        public object ShortDescription { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("rating")]
        public Rating Rating { get; set; }

        [JsonPropertyName("votes")]
        public Votes Votes { get; set; }

        [JsonPropertyName("movieLength")]
        public int? MovieLength { get; set; }

        [JsonPropertyName("totalSeriesLength")]
        public int? TotalSeriesLength { get; set; }

        [JsonPropertyName("seriesLength")]
        public int? SeriesLength { get; set; }

        [JsonPropertyName("ratingMpaa")]
        public object RatingMpaa { get; set; }

        [JsonPropertyName("ageRating")]
        public object AgeRating { get; set; }

        [JsonPropertyName("genres")]
        public List<Genre> Genres { get; set; }

        [JsonPropertyName("countries")]
        public List<Country> Countries { get; set; }

        [JsonPropertyName("top10")]
        public object Top10 { get; set; }

        [JsonPropertyName("top250")]
        public object Top250 { get; set; }

        [JsonPropertyName("isSeries")]
        public bool IsSeries { get; set; }

        [JsonPropertyName("ticketsOnSale")]
        public bool TicketsOnSale { get; set; }

        [JsonPropertyName("releaseYears")]
        public List<ReleaseYear> ReleaseYears { get; set; }

        [JsonPropertyName("poster")]
        public Poster Poster { get; set; }
    }

    public class Genre
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Poster
    {
        [JsonPropertyName("previewUrl")]
        public string PreviewUrl { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Rating
    {
        [JsonPropertyName("kp")]
        public double Kp { get; set; }

        [JsonPropertyName("imdb")]
        public double Imdb { get; set; }

        [JsonPropertyName("filmCritics")]
        public double FilmCritics { get; set; }

        [JsonPropertyName("russianFilmCritics")]
        public int RussianFilmCritics { get; set; }

        [JsonPropertyName("await")]
        public int? Await { get; set; }
    }

    public class ReleaseYear
    {
        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int? End { get; set; }
    }

    public class Films
    {
        [JsonPropertyName("docs")]
        public List<Doc> Docs { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("pages")]
        public int Pages { get; set; }
    }

    public class Votes
    {
        [JsonPropertyName("kp")]
        public int Kp { get; set; }

        [JsonPropertyName("imdb")]
        public int Imdb { get; set; }

        [JsonPropertyName("filmCritics")]
        public int FilmCritics { get; set; }

        [JsonPropertyName("russianFilmCritics")]
        public int RussianFilmCritics { get; set; }

        [JsonPropertyName("await")]
        public int Await { get; set; }
    }

