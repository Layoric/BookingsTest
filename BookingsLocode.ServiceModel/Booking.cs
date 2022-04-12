using System;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace BookingsLocode.ServiceModel;

public class Booking
{
    [AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public RoomType RoomType { get; set; }
    public int RoomNumber { get; set; }
    public DateTime BookingStartDate { get; set; }
    public DateTime? BookingEndDate { get; set; }
    public decimal Cost { get; set; }
    public string Notes { get; set; }
    public bool? Cancelled { get; set; }
}

public enum RoomType
{
    Single,
    Double,
    Queen,
    Twin,
    Suite,
}

public class QueryBookings : QueryDb<Booking>
{
    public int[] Ids { get; set; }
}

public class CreateBooking
    : ICreateDb<Booking>, IReturn<IdResponse>
{
    public string Name { get; set; }
    public RoomType RoomType { get; set; }
    public int RoomNumber { get; set; }
    public DateTime BookingStartDate { get; set; }
    public DateTime? BookingEndDate { get; set; }
    public decimal Cost { get; set; }
    public string Notes { get; set; }
}

public class UpdateBooking
    : IPatchDb<Booking>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public RoomType? RoomType { get; set; }
    public int? RoomNumber { get; set; }
    public DateTime? BookingStartDate { get; set; }
    public DateTime? BookingEndDate { get; set; }
    public decimal? Cost { get; set; }
    public bool? Cancelled { get; set; }
    public string Notes { get; set; }
}

public class DeleteBooking : IDeleteDb<Booking>, IReturnVoid
{
    public int Id { get; set; }
}