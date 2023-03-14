using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit_to_Start_Script : MonoBehaviour
{
public void Exit_to_Start_Menu()
    {
        SceneManager.LoadScene(0);
    }
}
