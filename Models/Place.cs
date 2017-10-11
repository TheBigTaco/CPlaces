using System;
using System.Collections.Generic;

namespace Vacation.Models
{
    public class Place
    {
        public string Location { set; get; }
        public string Image { set; get; }
        private static List<Place> _places = new List<Place> {};
        public int Id {get; private set;}

        public Place (string place, string image)
        {
            Location = place;
            Image = image;
            _places.Add(this);
            Id = _places.Count;
        }
        public static List<Place> GetAll()
        {
            return _places;
        }
        public static void ClearAll()
        {
            _places.Clear();
        }
        public static Place Find(int searchId)
        {
            return _places[searchId - 1];
        }
    }
}
