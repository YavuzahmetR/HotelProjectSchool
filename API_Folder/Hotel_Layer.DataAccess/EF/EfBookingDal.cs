using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.DataAccess.Concrete;
using Hotel_Layer.DataAccess.Repositories;
using Hotel_Layer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.DataAccess.EF
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {

        }

        public void BookingStatusChangeApprovedAPI(Booking booking)
        {
            using (var context = new Context())
            {
                var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
                values.Status = "Onaylandı";
                context.SaveChanges();
            }
        }

        public void BookingStatusChangeApprovedAdmin(int id)
        {
            using (var context = new Context())
            {
                var values = context.Bookings.Find(id);
                if (values != null)
                {
                    values.Status = "Onaylandı";
                    context.SaveChanges();
                }
            }
        }

        public int GetBookingCount()
        {
            using (var context = new Context())
            {
                var value = context.Bookings.Count();
                return value;
            }
               
        }

        public List<Booking> Last6Bookings()
        {
            using (var context = new Context())
            {
                var values = context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
                return values;
            }
           
        }

        public void BookingStatusChangeCanceled(int id)
        {
            using (var context = new Context())
            {
                var values = context.Bookings.Find(id);
                if(values != null)
                {
                    values.Status = "İptal Edildi";
                    context.SaveChanges();
                }
            }
        }

        public void BookingStatusChangeWaitLine(int id)
        {
            using (var context = new Context())
            {
                var values = context.Bookings.Find(id);
                if (values != null)
                {
                    values.Status = "Rezervasyon Beklemede";
                    context.SaveChanges();
                }
            }
        }
    }
}
