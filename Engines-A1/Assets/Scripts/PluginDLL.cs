using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class PluginDLL : MonoBehaviour
{
    [DllImport("MidtermDLL")]
    private static extern int PrintANumber();

    [DllImport("MidtermDLL")]
    private static extern int AddTwoIntegers(int i1, int i2);

    [DllImport("MidtermDLL")]
    private static extern int AddTwoFloats(float f1, float f2);

    void Start()
    {
        Debug.Log(PrintANumber());
        Debug.Log(AddTwoIntegers(2, 2));
        Debug.Log(AddTwoFloats(2.5f, 4f));
    }

    void Update()
    {
        
    }
}
