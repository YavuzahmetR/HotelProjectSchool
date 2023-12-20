
using Hotel_Layer.Business.Abstract;
using Hotel_Layer.Business.Concrete;
using Hotel_Layer.DataAccess.Abstract;
using Hotel_Layer.DataAccess.Concrete;
using Hotel_Layer.DataAccess.EF;

namespace HotelProjeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>();
            builder.Services.AddScoped<IStaffDal,EfStaffDal>();
            builder.Services.AddScoped<IStaffService,StaffManager>();

            builder.Services.AddScoped<IServiceDal, EfServiceDal>();
            builder.Services.AddScoped<IService_Service, ServiceManager>();

            builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

            builder.Services.AddScoped<ISubscriberDal, EfSubscriberDal>();
            builder.Services.AddScoped<ISubscriberService, SubscriberManager>();

            builder.Services.AddScoped<IRoomDal, EfRoomDal>();
            builder.Services.AddScoped<IRoomService, RoomManager>();

            builder.Services.AddScoped<IAboutDal, EfAboutDal>();
            builder.Services.AddScoped<IAboutService, AboutManager>();

            builder.Services.AddScoped<IBookingDal, EfBookingDal>();
            builder.Services.AddScoped<IBookingService, BookingManager>();

            builder.Services.AddScoped<IContactDal, EfContactDal>();
            builder.Services.AddScoped<IContactService, ContactManager>();

            builder.Services.AddScoped<IGuestDal, EfGuestDal>();
            builder.Services.AddScoped<IGuestService, GuestManager>();

            builder.Services.AddScoped<ISendMessageDal, EfSendMessageDal>();
            builder.Services.AddScoped<ISendMessageService, SendMessageManager>();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("ApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("ApiCors");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}