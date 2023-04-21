using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        //Singleton.Instance.TestSingleton();
        Test1.Instance.TestFunc();
    }
}
