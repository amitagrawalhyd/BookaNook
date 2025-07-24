namespace BookaNook.Models
{
    // ReSharper disable once CheckNamespace
    // ReSharper disable once ClassNeverInstantiated.Global
    public class PropertyImage
    {
        // ReSharper disable once InconsistentNaming
        public int ImageID { get; set; }

        // ReSharper disable once InconsistentNaming
        public int PropertyID { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        // ReSharper disable once InconsistentNaming
        public string ImageURL { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public bool IsCoverImage { get; set; }

        // Navigation Property
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Property Property { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}