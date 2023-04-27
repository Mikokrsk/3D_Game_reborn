using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
//using UnityEngine.Windows;

public class Setings_Menu_Script : MonoBehaviour
{
    public GameObject Choice_menu;
    public Text[] _text ;

    private KeyCode[] _allKeyCodes ;
    private KeyCode[] _keyCodes ;

    private const string saveKey = "Setings_Menu_Save";

    private void Save()
    {
        SaveManager.Save(saveKey,GetSaveSnapshot());
    }

    private SaveData.Menu_Save GetSaveSnapshot()
    {
        var data = new SaveData.Menu_Save()
        { 
            Run_Forward = _keyCodes[0],
            Run_Back = _keyCodes[1],
            Run_Left = _keyCodes[2],
            Run_Right = _keyCodes[3],
            Attack_1 = _keyCodes[4],
            Attack_2 = _keyCodes[5],
            Attack_3 = _keyCodes[6],        
        };
        return data;
    }

    private void Load()
    {
        var data = SaveManager.Load<SaveData.Menu_Save>(saveKey);
        _keyCodes[0] = data.Run_Forward;
        _keyCodes[1] = data.Run_Left;
        _keyCodes[2] = data.Run_Back;
        _keyCodes[3] = data.Run_Right;
        _keyCodes[4] = data.Attack_1;
        _keyCodes[5] = data.Attack_2;
        _keyCodes[6] = data.Attack_3;
    }

    private void Awake()
    {                  
        _keyCodes = new KeyCode[_text.Length];
        _allKeyCodes = (KeyCode[])System.Enum.GetValues(typeof(KeyCode));
    }

    private void Start()
    {
        Load();
        Refreash_Texts();
    }

    private void Refreash_Texts()
    {
        int x = 0;
        foreach (var item in _keyCodes)
        {
            _text[x].text = (item).ToString();
            x++;
        }
    }

    private void FindDuplicates(KeyCode num)
    { 
        int x = 0;
        foreach (var item in _keyCodes)
        {
            if (_keyCodes[x] == num)
            {
             _keyCodes[x] = KeyCode.None;
             _text[x].text = KeyCode.None.ToString();
            }       
            x++;
        }
    }

    public void Default_values()
    {
        _keyCodes[0] = KeyCode.W;
        _keyCodes[1] = KeyCode.A;
        _keyCodes[2] = KeyCode.S;
        _keyCodes[3] = KeyCode.D;
        _keyCodes[4] = KeyCode.Alpha1;
        _keyCodes[5] = KeyCode.Alpha2;
        _keyCodes[6] = KeyCode.Alpha3;

        Refreash_Texts();
        Save();
    }

    public void GetKeyCode(int num_button)
    {
        Choice_menu.SetActive(true);
        StartCoroutine(Coroutine(num_button));
    }

    IEnumerator Coroutine(int x)
    {
       
        if (Input.anyKeyDown)
        {
           // Debug.Log("111111111111111111");
            for (int i = 0; i < _allKeyCodes.Length; i++)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    StopCoroutine(Coroutine(x));
                    break;
                }
                else
                {
                    if (Input.GetKey(_allKeyCodes[i]))
                    {
                        FindDuplicates(_allKeyCodes[i]);
                        _text[x].text = (_allKeyCodes[i]).ToString();
                        _keyCodes[x] = _allKeyCodes[i]; 
                        Save();
                        StopCoroutine(Coroutine(x));
                        break;
                    }
                }
            }
            Choice_menu.SetActive(false);
            StopCoroutine(Coroutine(x));
        }
        else
        {
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(Coroutine(x));
        }
    }
}
