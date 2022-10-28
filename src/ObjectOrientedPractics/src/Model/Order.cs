using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        public int Id { get; }

        public DateTime CreateDate { get; }

        public List<Item> Items { get; } = new List<Item>();

        public OrderStatus Status { set; get; }

        public Address DeliveryAddress { get; set; }

        public double Amount
        {
            get
            {
                return Items.Sum(item => item.Cost);
            }
        }

        public Order()
        {
            Id = IdGenerator.GetNextId();
            CreateDate = DateTime.Now;
            Status = OrderStatus.New;
        }
    }
}