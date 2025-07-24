using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BookaNook.Models;

namespace BookaNook.ViewModels
{
    public class PropertyListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Property> _properties;
        public ObservableCollection<Property> Properties
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
                    Title = "Malaysian Township, 15 Block",
                    City = "Hyderabad",
                    PricePerNight = 350,
                    DateListed = DateTime.Now.AddDays(-30),
                    Images = new Collection<PropertyImage>
                    {
                        new PropertyImage { ImageURL = "https://teja12.kuikr.com/is/a/c/800x600/gallery_images/original/589c4e6c56a82.jpg" },
                        new PropertyImage { ImageURL = "https://img.staticmb.com/mbphoto/property/cropped_images/2025/Jul/04/Photo_h470_w1080/80318551_5_1751630346399-904_470_1080.jpg" },
                        new PropertyImage { ImageURL = "https://img.staticmb.com/mbphoto/property/cropped_images/2025/Jul/04/Photo_h470_w1080/80318551_2_1751630328890-0708_470_1080.jpg" },
                        new PropertyImage {ImageURL = "https://imagecdn.99acres.com/media1/26683/14/533674945O-1732640341283.jpg"}
                    }
                },
                new Property
                {
                    PropertyID = 2,
                    Title = "Malaysian Township, 19 Block",
                    City = "Hyderabad",
                    PricePerNight = 220,
                    DateListed = DateTime.Now.AddDays(-60),
                    Images = new Collection<PropertyImage>
                    {
                        new PropertyImage { ImageURL = "https://teja12.kuikr.com/is/a/c/800x600/gallery_images/original/589c4e6c56a82.jpg" },
                        new PropertyImage { ImageURL = "https://imagecdn.99acres.com/media1/26683/14/533674949O-1732640341440.jpg" }
                    }
                },
                new Property
                {
                    PropertyID = 3,
                    Title = "Falaknuma Palace",
                    City = "Hyderabad",
                    PricePerNight = 450,
                    DateListed = DateTime.Now.AddDays(-15),
                    Images = new Collection<PropertyImage>
                    {
                        new PropertyImage { ImageURL = "https://www.hyderabadtourism.travel/images/visiting-places/headers/taj-falaknuma-palacer-hyderabad-tourism-entryfee-timings-package-tour.jpg" },
                        new PropertyImage { ImageURL = "https://www.hyderabadtourism.travel/administrator/cache/preview/0fed5d9722988b909411b1a0fa2a5cdf.jpg" }
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
