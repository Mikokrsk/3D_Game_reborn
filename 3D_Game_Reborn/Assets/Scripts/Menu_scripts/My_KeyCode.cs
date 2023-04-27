using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_KeyCode
{
    private string Key_Name;
    private KeyCode Key_Value;
    
    public My_KeyCode(string Key_Name,KeyCode Key_Value) 
    {
        this.Key_Name= Key_Name;
        this.Key_Value = Key_Value;
    }


    public My_KeyCode()
    {
        this.Key_Name = "null";
        this.Key_Value = KeyCode.None;
    }

    public string GetKeyName()
    {
        return this.Key_Name;
    }

    public KeyCode GetKeyValue()
    {
        return this.Key_Value;
    }  
    
    public void SetKeyName(string Key_Name)
    {
        this.Key_Name = Key_Name;
    }

    public void SetKeyValue(KeyCode Key_Value)
    {
        this.Key_Value = Key_Value;
    }
}
