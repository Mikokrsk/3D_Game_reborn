using UnityEngine;

namespace Menu
{

    public static class Test_script
    {
        public static KeyCode _run_Forward;
        public static KeyCode _run_Left;
        public static KeyCode _run_Back;
        public static KeyCode _run_Right;
        public static KeyCode _attack_1;
        public static KeyCode _attack_2;
        public static KeyCode _attack_3;

/*        public Test_script(KeyCode forward, KeyCode left, KeyCode back, KeyCode right, KeyCode attack_1, KeyCode attack_2, KeyCode attack_3)
        {
            _run_Forward = forward;
            _run_Left = left;
            _run_Back = back;
            _run_Right = right;
            _attack_1 = attack_1;
            _attack_2 = attack_2;
            _attack_3 = attack_3;
        }*/
/*
        public KeyCode GetForward() { return _run_Forward; }
        public KeyCode GetLeft() { return _run_Left; }
        public KeyCode GetBack() { return _run_Back; }
        public KeyCode GetRight() { return _run_Right; }
        public KeyCode GetAttack_1() { return _attack_1; }
        public KeyCode GetAttack_2() { return _attack_2; }
        public KeyCode GetAttack_3() { return _attack_3; }

        public void SetForward(KeyCode forward) { _run_Forward = forward; }
        public void SetLeft(KeyCode left) { _run_Left = left; }
        public void SetBack(KeyCode back) { _run_Back = back; }
        public void SetRight(KeyCode right) { _run_Right = right; }
        public void SetAttack_1(KeyCode attack_1) { _attack_1 = attack_1; }
        public void SetAttack_2(KeyCode attack_2) { _attack_2 = attack_2; }
        public void SetAttack_3(KeyCode attack_3) { _attack_3 = attack_3; }*/

        public static void Print()
        {
            Debug.Log($"_run_Forward = {_run_Forward} _run_Left = {_run_Left} _run_Back = {_run_Back} _run_Right = {_run_Right}" +
                $" _attack_1 = {_attack_1} _attack_2 = {_attack_2} _attack_3 = {_attack_3}");
        }
    }
}
