using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
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
        //Arriba
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime * 10;
            anim.SetBool("up", true);
        } else {
            anim.SetBool("up", false);
        }
        //Abajo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * 10;
            anim.SetBool("down", true);
        } else {
            anim.SetBool("down", false);
        }
        //Derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * 10;
            anim.SetBool("right", true);
        } else {
            anim.SetBool("right", false);
        }
        //Izquierda    
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * 10;
            anim.SetBool("left", true);
        } else {
            anim.SetBool("left", false);
        }

    }
}
