using System;
using System.Collections.Generic;
using System.Linq;
using HotelBooking.Models;

namespace HotelBooking.Data.Repositories
{
    public class RoomRepository : IRepository<Room>
    {
        private readonly HotelBookingContext db;

        public RoomRepository(HotelBookingContext context)
        {
            db = context;
        }

        public void Add(Room entity)
        {
            db.Room.Add(entity);
            db.SaveChanges();
        }

        public void Edit(Room entity)
        {
            db.Room.Update(entity);
            db.SaveChanges();
        }

        public Room Get(int id)
        {
            try
            {
                return db.Room.Find(id);
            } catch (ArgumentNullException)
            {
                return null;
            }
        }

        public IEnumerable<Room> GetAll()
        {
            return db.Room.ToList();
        }

        public void Remove(int id)
        {
            try
            {
                db.Room.Remove(db.Room.Find(id));
            } catch (ArgumentNullException)
            {
                return;
            }
        }
    }
}
