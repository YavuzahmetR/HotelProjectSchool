using Hotel_Layer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.DataAccess.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApprovedAPI(Booking booking);
        void BookingStatusChangeApprovedAdmin(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
    }
}
