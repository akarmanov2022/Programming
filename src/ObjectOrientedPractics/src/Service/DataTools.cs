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
                if (predicate(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public static void Sort(List<Item> items, Func<Item, Item, bool> compare)
        {
            for (var i = 0; i < items.Count; i++)
            {
                for (var j = 0; j < items.Count; j++)
                {
                    if (!compare(items[i], items[j])) continue;
                    (items[i], items[j]) = (items[j], items[i]);
                }
            }
        }
    }
}