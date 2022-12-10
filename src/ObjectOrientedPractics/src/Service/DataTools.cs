using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service
{
    public static class DataTools
    {
        public static List<Item> FindByPredicate(List<Item> items, Predicate<Item> predicate)
        {
            var list = new List<Item>();
            foreach (var item in items)
            {
                if (predicate.Invoke(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}