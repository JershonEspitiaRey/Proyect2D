using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2D : MonoBehaviour
{

    Animator animador;
    float movimientoHorizontal;
    float movimientoVertical;
        
    // Start is called before the first frame update
    void Start()
    {
        animador = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ReadMovement();

        float reposoX = 0f;
        float reposoY = 0f;

        //habilitar caminado
        if(movimientoHorizontal != 0 || movimientoVertical != 0){
            transform.position = transform.position + new Vector3(movimientoHorizontal * Time.deltaTime, movimientoVertical * Time.deltaTime, 0);
            animador.SetBool("reposoCaminar", true);
        }
        else{
            animador.SetBool("reposoCaminar", false);
        }

        //habilitar correr
        if((movimientoHorizontal != 0 || movimientoVertical != 0) && Input.GetKey(KeyCode.LeftShift)){
            transform.position = transform.position + new Vector3(movimientoHorizontal * Time.deltaTime, movimientoVertical * Time.deltaTime, 0);
            animador.SetBool("pressShift", true);
        }else{
            animador.SetBool("pressShift", false);
        }

        //Animaciones horizontales
        animador.SetFloat("ejeX", movimientoHorizontal);

        //Animaciones verticales
        animador.SetFloat("ejeY", movimientoVertical);

        //Efecto espejo en eje X
        if(movimientoHorizontal > 0){
            transform.localScale = new Vector3(-1,1,1);
        }
        if(movimientoHorizontal < 0){
            transform.localScale = new Vector3(1,1,1);
        }

        //Condiciones para ir guardando la dirección a donde va el personaje
        if(movimientoHorizontal < 0){
            reposoX = -1f;
        }else if(movimientoHorizontal > 0){
            reposoX = 1f;
        }

        if(movimientoVertical < 0){
            reposoY = -1f;
        }else if(movimientoVertical > 0){
            reposoY = 1f;
        }

        //se asignan los valores en el animator de reposo
        if(movimientoHorizontal != 0 || movimientoVertical != 0){
                animador.SetFloat("ValorY", reposoY);
                animador.SetFloat("ValorX", reposoX);
        }
    }

    //Metodo para leer movimiento por teclas
    void ReadMovement(){
         movimientoHorizontal= Input.GetAxisRaw("Horizontal");
         movimientoVertical = Input.GetAxisRaw("Vertical");
    }
}
