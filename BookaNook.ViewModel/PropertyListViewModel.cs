using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BookaNook.Models;

namespace BookaNook.ViewModel
{
    public class PropertyListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<BookaNook.Models.Property> _properties;
        public ObservableCollection<BookaNook.Models.Property> Properties
        {
            get => _properties;
            set
            {
                _properties = value;
                OnPropertyChanged();
            }
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public PropertyListViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            // In a real app, you would fetch this data from a service connected to your SQL database.
            // For now, we'll use mock data.
            LoadMockProperties();
        }

        private void LoadMockProperties()
        {
            Properties = new ObservableCollection<Property>
            {
                new Property
                {
                    PropertyID = 1,
                    Title = "Cozy Beachfront Cottage",
                    City = "Malibu, California",
                    PricePerNight = 350,
                    DateListed = DateTime.Now.AddDays(-30),
                    Images = new Collection<PropertyImage>
                    {
                        new PropertyImage { ImageURL = "https://placehold.co/600x400/3498db/ffffff?text=Beach+View" },
                        new PropertyImage { ImageURL = "https://placehold.co/600x400/9b59b6/ffffff?text=Living+Room" },
                        new PropertyImage { ImageURL = "https://placehold.co/600x400/e74c3c/ffffff?text=Bedroom" }
                    }
                },
                new Property
                {
                    PropertyID = 2,
                    Title = "Modern Downtown Loft",
                    City = "New York, New York",
                    PricePerNight = 220,
                    DateListed = DateTime.Now.AddDays(-60),
                    Images = new Collection<PropertyImage>
                    {
                        new PropertyImage { ImageURL = "https://placehold.co/600x400/2ecc71/ffffff?text=Cityscape" },
                        new PropertyImage { ImageURL = "https://placehold.co/600x400/f1c40f/ffffff?text=Interior" }
                    }
                },
                new Property
                {
                    PropertyID = 3,
                    Title = "Rustic Mountain Cabin",
                    City = "Aspen, Colorado",
                    PricePerNight = 450,
                    DateListed = DateTime.Now.AddDays(-15),
                    Images = new Collection<PropertyImage>
                    {
                        new PropertyImage { ImageURL = "https://placehold.co/600x400/e67e22/ffffff?text=Mountain+Retreat" },
                        new PropertyImage { ImageURL = "https://placehold.co/600x400/1abc9c/ffffff?text=Cozy+Fireplace" }
                    }
                }
            };
        }

#pragma warning disable CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        {
            // ReSharper disable once ConditionalAccessQualifierIsNonNullableAccordingToAPIContract
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
