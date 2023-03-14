using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Controller : MonoBehaviour
{
    public Animator anim;

    private static KeyCode _run_Forward ;
    private static KeyCode _run_Left ;
    private static KeyCode _run_Back ;
    private static KeyCode _run_Right ;
    private float speed = 5f;
    //Move_Controller move = new Move_Controller();
    // Start is called before the first frame update
    void Start()
    {
      //  Move_Controller move =new Move_Controller();
        // Setings_Menu_Script setings= new Setings_Menu_Script();
        Set_value();
        anim = GetComponent<Animator>();
    }

    public static void Set_value()
    {

        _run_Forward = Setings_Menu_Script._run_Forward;
        _run_Left = Setings_Menu_Script._run_Left;
        _run_Back = Setings_Menu_Script._run_Back;
        _run_Right = Setings_Menu_Script._run_Right;
    }
    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("isWalk") && anim.GetBool("isLive"))
            Walk();
    } 

    void Walk()
        {
        if (Input.GetKey(_run_Forward) && Input.GetKey(_run_Back) || Input.GetKey(_run_Forward) && Input.GetKey(_run_Back))
        {
            anim.SetBool("Walk", false);
        }
        else
        {
            // Forward
            if (Input.GetKey(_run_Forward))
                {
                    gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                if (Input.GetKeyUp(_run_Forward))
                {
                    anim.SetBool("Walk", false);
                }


                //Back
                if (Input.GetKey(_run_Back))
                {
                    gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                 if (Input.GetKeyUp(_run_Back))
                {
                    anim.SetBool("Walk", false);
                }


                //Right
                if (Input.GetKey(_run_Right))
                {
                    gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                 if(Input.GetKeyUp(_run_Right))
                {
                    anim.SetBool("Walk", false);
                }


                //Left
                if (Input.GetKey(_run_Left))
                {
                    gameObject.transform.position -= gameObject.transform.right * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                if (Input.GetKeyUp(_run_Left))
                {
                    anim.SetBool("Walk", false);
                }
            }
    }
}
