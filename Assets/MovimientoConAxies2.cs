using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoConAxies2 : MonoBehaviour
{
    Animator anim2;
    public float velocidadMovimiento = 1f;

    // Start is called before the first frame update
    void Start()
    {
        anim2 = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        //Animaciones laterales
        anim2.SetFloat("Derecha", movimientoHorizontal);
        anim2.SetFloat("Izquierda", movimientoHorizontal);
        //Animaciones horizontales
        anim2.SetFloat("Arriba", movimientoVertical);
        anim2.SetFloat("Abajo", movimientoVertical);

        transform.position = transform.position + new Vector3(movimientoHorizontal * velocidadMovimiento * Time.deltaTime, movimientoVertical * velocidadMovimiento * Time.deltaTime, 0);

    }
}
