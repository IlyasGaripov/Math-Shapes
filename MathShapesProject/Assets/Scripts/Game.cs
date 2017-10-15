using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour { 

    private SafeInt stars = new SafeInt(0);
    // Use this for initialization
    void Start()
    {
        Debug.Log("Default stars: " + stars.GetValue());
        Debug.Log("Inc stars: " + stars.GetValue());
    }

    // Update is called once per frame
    void Update()
    {

    }
}

[System.Serializable]
public class SafeInt
{
    private int value;
    private int offset;

    public SafeInt(int value = 0)
    {
        System.Random rnd = new System.Random();
        offset = rnd.Next(-1000, 1000);
        this.value = value + offset;
    }
    
    public int GetValue()
    {
        return value - offset;
    }
    public void Dispose()
    {
        value = 0;
        offset = 0;
    }
    public override string ToString()
    {
        return GetValue().ToString();
    }
    public static SafeInt operator +(SafeInt i0, SafeInt i1)
    {
        return new SafeInt(i0.GetValue() + i1.GetValue());
    }
    public static SafeInt operator -(SafeInt i0, SafeInt i1)
    {
        return new SafeInt(i0.GetValue() - i1.GetValue());
    }
    public static SafeInt operator *(SafeInt i0, SafeInt i1)
    {
        return new SafeInt(i0.GetValue() * i1.GetValue());
    }
    public static SafeInt operator /(SafeInt i0, SafeInt i1)
    {
        return new SafeInt(i0.GetValue() / i1.GetValue());
    }
    public static SafeInt operator ++(SafeInt i0)
    {
        return new SafeInt(i0.GetValue() + new SafeInt(1).GetValue());
    }
    public static SafeInt operator --(SafeInt i0)
    {
        return new SafeInt(i0.GetValue() - new SafeInt(1).GetValue());
    }

}

