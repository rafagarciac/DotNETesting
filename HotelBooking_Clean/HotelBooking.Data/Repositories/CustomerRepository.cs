using System;
using System.Collections.Generic;
using System.Linq;
using HotelBooking.Models;

namespace HotelBooking.Data.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly HotelBookingContext db;

        public CustomerRepository(HotelBookingContext context)
        {
            db = context;
        }

        public void Add(Customer entity)
        {
            db.Customer.Add(entity);
            db.SaveChanges();
        }

        public void Edit(Customer entity)
        {
            db.Customer.Update(entity);
            db.SaveChanges();
        }

        public Customer Get(int id)
        {
            return db.Customer.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return db.Customer.ToList();
        }

        public void Remove(int id)
        {
            db.Customer.Remove(db.Customer.Find(id));
        }
    }
}
