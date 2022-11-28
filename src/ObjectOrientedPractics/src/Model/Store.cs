using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект - магазин, который хранит в себе списки <see cref="Item"/> и <see cref="Customer"/>.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Возвращает или задает список объектов типа <see cref="Item"/>
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Возвращает или задает список объектов типа <see cref="Customer"/>.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}