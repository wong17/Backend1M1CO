﻿using OpenWeatherMapDemo.Model;

namespace OpenWeatherMapDemo.Models
{
    public class City
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? country { get; set; }
        public Coord? coord { get; set; }
    }
}
