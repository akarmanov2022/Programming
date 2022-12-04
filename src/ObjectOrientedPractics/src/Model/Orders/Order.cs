using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Представляет объект - заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Возвращает идентификатор заказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Возвращает или задает список всех <see cref="Item"/> в заказе.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Возвращает или задает статуст заказа.
        /// </summary>
        public OrderStatus Status { set; get; }

        /// <summary>
        /// Возвращает или задает адрес доставки.
        /// </summary>
        public Address DeliveryAddress { get; set; } = new Address();

        /// <summary>
        /// Возвращает историю статусов заказа.
        /// </summary>
        public Dictionary<DateTime, OrderStatus> History { get; } = new Dictionary<DateTime, OrderStatus>();

        /// <summary>
        /// Возвращает общую стоимость всех товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                return Items.Sum(item => item.Cost);
            }
        }

        public double DiscountAmount { get; set; }

        public double TotalAmount => Amount - DiscountAmount;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Order()
        {
            Id = IdGenerator.GetNextId();
            CreateDate = DateTime.Now;
            Status = OrderStatus.New;
        }
    }
}