using Hotel_Layer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.Business.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TBookingStatusChangeApprovedAPI(Booking booking);
        void TBookingStatusChangeApprovedAdmin(int id);
        int TGetBookingCount();
        void TBookingStatusChangeCanceled(int id);
        void TBookingStatusChangeWaitLine(int id);
        List<Booking> TLast6Bookings();
    }
}
