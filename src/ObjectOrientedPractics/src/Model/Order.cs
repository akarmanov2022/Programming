using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект - заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Возвращает идентификатор заказа.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreateDate { get; }

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
        public Address DeliveryAddress { get; set; }

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