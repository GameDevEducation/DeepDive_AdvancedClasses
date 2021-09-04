using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoKeyValueStorage : MonoBehaviour
{
    Dictionary<string, object> Storage = new Dictionary<string, object>();

    public void Set<T>(string key, T value)
    {
        Storage[key] = value;
    }

    public T Get<T>(string key)
    {
        return (T)Storage[key];
    }

    // Start is called before the first frame update
    void Start()
    {
        // store a value - can infer type from parameter
        Set<int>("Test1", 52);
        Set("Test2", 43);

        // retrieve a value - cannot infer type from return value
        int storedValue = Get<int>("Test1");
        Debug.Log(storedValue);

        DemoDictionary<string, int> test = new DemoDictionary<string, int>();
        test.Set("TestKey", 55);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
