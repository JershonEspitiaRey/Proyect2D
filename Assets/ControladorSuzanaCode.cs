using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSuzanaCode : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Derecha
        if(Input.GetKeyDown(KeyCode.A)){
            anim.SetBool("right", true);
        }
        if(Input.GetKeyUp(KeyCode.A)){
            anim.SetBool("right", false);
        }

        //izquierda
        if(Input.GetKeyDown(KeyCode.D)){
            anim.SetBool("left", true);
        }
        if(Input.GetKeyUp(KeyCode.D)){
            anim.SetBool("left", false);
        }

        //Arriba
        if(Input.GetKeyDown(KeyCode.W)){
            anim.SetBool("up", true);
        }
        if(Input.GetKeyUp(KeyCode.W)){
            anim.SetBool("up", false);
        }

        //Abajo
        if(Input.GetKeyDown(KeyCode.S)){
            anim.SetBool("down", true);
        }
        if(Input.GetKeyUp(KeyCode.S)){
            anim.SetBool("down", false);
        }

    }
}
