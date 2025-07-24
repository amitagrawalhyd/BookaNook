namespace BookaNook.Models
{
#pragma warning disable CA1050
    // ReSharper disable once ClassNeverInstantiated.Global
    // ReSharper disable once CheckNamespace
    public class Booking
#pragma warning restore CA1050
    {
        // ReSharper disable once InconsistentNaming
        public int BookingID { get; set; }

        // ReSharper disable once InconsistentNaming
        public int GuestID { get; set; }

        // ReSharper disable once InconsistentNaming
        public int PropertyID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
        public decimal TotalPrice { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public string BookingStatus { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public DateTime BookingDate { get; set; }

        // Navigation Properties
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public User Guest { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Property Property { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}