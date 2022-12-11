using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoConAxies : MonoBehaviour
{
    Animator anim;
    public float velocidadMovimiento = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        //Animaciones laterales
        anim.SetFloat("activoDerecha", movimientoHorizontal);
        anim.SetFloat("activoIzquierda", movimientoHorizontal);
        //Animaciones horizontales
        anim.SetFloat("activoArriba", movimientoVertical);
        anim.SetFloat("activoAbajo", movimientoVertical);

        transform.position = transform.position + new Vector3(movimientoHorizontal * velocidadMovimiento * Time.deltaTime, movimientoVertical * velocidadMovimiento * Time.deltaTime, 0);

    }
}
