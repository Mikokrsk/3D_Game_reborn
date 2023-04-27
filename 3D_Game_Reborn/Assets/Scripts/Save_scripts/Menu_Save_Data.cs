using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveData
{
    [System.Serializable]
    public class Menu_Save
    {
        public KeyCode Run_Forward ;
        public KeyCode Run_Left ;
        public KeyCode Run_Back ;
        public KeyCode Run_Right;
        public KeyCode Attack_1 ;
        public KeyCode Attack_2 ;
        public KeyCode Attack_3 ;

        public List<My_KeyCode> Keys =new List<My_KeyCode>();

        public bool isFull_screen;
        public int ResolutionIndex;
        public int QualityIndex;

        public Menu_Save()
        {
            Run_Forward= KeyCode.W ;
            Run_Left= KeyCode.A;
            Run_Back= KeyCode.S;
            Run_Right = KeyCode.D;
            Attack_1 = KeyCode.Mouse0;
            Attack_2= KeyCode.Mouse1;
            Attack_3 = KeyCode.G;

            isFull_screen = true;
            ResolutionIndex = Screen.resolutions.Length-1;
            QualityIndex = 0;
        }
    }
}