using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : SingletonCenter<Test1>
{
    public void TestFunc()
    {
        print("this is a func from Test1!");
    }
}
