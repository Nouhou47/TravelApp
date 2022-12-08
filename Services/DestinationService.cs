using TravelApp.Models;

namespace TravelApp.Services
{
    public class DestinationService
    {
        static DestinationService _instance;

        public static DestinationService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DestinationService();

                return _instance;
            }
        }

        internal List<GalleryItem> Gallery
        {
            get
            {
                return new List<GalleryItem>
                {
                    new GalleryItem { Id = 1, Image = "monument_reunification.jpg" },
                    new GalleryItem { Id = 2, Image = "monument_rnd_point_deido.jpg" },
                    new GalleryItem { Id = 3, Image = "kribi_beach.jpg" },
                    new GalleryItem { Id = 4, Image = "german_bridge.jpg" }
                };
            }
        }

        public List<Destination> RecommendedDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Cameroon's Reunification Monument", Place = "Carrefour de la Reunification, Yaounde", Image = "monument_reunification.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                    new Destination { Name = "Monument du Rond Point Deido", Place = "Rond Point Deido, Douala", Image = "monument_rnd_point_deido.jpg", Price = 90, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                    new Destination { Name = "Spendide plage de kribi", Place = "Kribi", Image = "kribi_beach.jpg", Price = 60, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                    new Destination { Name = "Pont Construit par les Allemands", Place = "Edea", Image = "german_bridge.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                };
            }
        }

        public List<Destination> TopDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Cameroon's Reunification Monument", Place = "Carrefour de la Reunification, Yaounde", Image = "monument_reunification.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                    new Destination { Name = "Monument du Rond Point Deido", Place = "Rond Point Deido, Douala", Image = "monument_rnd_point_deido.jpg", Price = 90, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                    new Destination { Name = "Spendide plage de kribi", Place = "Kribi", Image = "kribi_beach.jpg", Price = 60, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                    new Destination { Name = "Pont Construit par les Allemands", Place = "Edea", Image = "german_bridge.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = Gallery },
                };
            }
        }
    }
}