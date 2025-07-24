namespace BookaNook.Models
{
    // ReSharper disable once CheckNamespace
    // ReSharper disable once ClassNeverInstantiated.Global
    public class PropertyAmenity
    {
        // ReSharper disable once UnusedMember.Global
        // ReSharper disable once InconsistentNaming
        public int PropertyID { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Property Property { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        // ReSharper disable once UnusedMember.Global
        // ReSharper disable once InconsistentNaming
        public int AmenityID { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Amenity Amenity { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}