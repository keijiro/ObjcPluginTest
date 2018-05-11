using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class Test : MonoBehaviour
{
    [DllImport("ObjcPluginTest")]
    static extern IntPtr Plugin_CreateObject();

    [DllImport("ObjcPluginTest")]
    static extern void Plugin_DestroyObject(IntPtr pointer);

    [SerializeField] int _objectCount = 300;

    int _counter;

    void Update()
    {
        if (_counter < _objectCount)
        {
            Plugin_DestroyObject(Plugin_CreateObject());
            _counter++;
        }
    }
}
