﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Module_37_HomeApp
{
    /// <summary>
    /// Группируемая универсальная коллекция
    /// </summary>
    public class Group<K, T> : ObservableCollection<T>
    {
        public K Name { get; private set; }
        public Group(K name, IEnumerable<T> items)
        {
            Name = name;
            foreach (T item in items)
                Items.Add(item);
        }
    }
}
