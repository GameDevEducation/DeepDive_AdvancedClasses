using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoDictionary<K, V>
{
    List<K> Keys = new List<K>();
    List<V> Values = new List<V>();

    public void Set(K key, V value)
    {
        int index = Keys.IndexOf(key);
        if (index >= 0)
            Values[index] = value;
        else
        {
            Keys.Add(key);
            Values.Add(value);
        }
    }
}
