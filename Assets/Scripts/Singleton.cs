using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton :MonoBehaviour
{
    private static Singleton instance;
    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        instance = this;
    }

    public void TestSingleton()
    {
        Debug.Log("aa");
    }
}
