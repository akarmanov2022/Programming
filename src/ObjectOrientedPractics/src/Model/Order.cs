using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private Address _deliveryAddress;

        private readonly List<Item> _items;

        public int Id { get; }

        public DateTime CreateDate { get; }

        private double Amount
        {
            get
            {
                return _items?.Sum(item => item.Cost) ?? 0D;
            }
        }

        public Order(Address deliveryAddress, List<Item> items)
        {
            _deliveryAddress = deliveryAddress;
            _items = items;
            Id = IdGenerator.GetNextId();
            CreateDate = DateTime.Now;
        }
    }
}