namespace BookaNook.Models
{

    // ReSharper disable once CheckNamespace
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Review
    {
        // ReSharper disable once InconsistentNaming
        public int ReviewID { get; set; }

        // ReSharper disable once InconsistentNaming
        public int BookingID { get; set; }

        // ReSharper disable once InconsistentNaming
        public int GuestID { get; set; }

        // ReSharper disable once InconsistentNaming
        public int PropertyID { get; set; }
        public int Rating { get; set; }
        // ReSharper disable once UnusedMember.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public string Comment { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public DateTime ReviewDate { get; set; }

        // Navigation Properties
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Booking Booking { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public User Guest { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Property Property { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}