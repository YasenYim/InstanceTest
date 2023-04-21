using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCenter<T> : MonoBehaviour where T:SingletonCenter<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        instance = this as T;
    }
}
