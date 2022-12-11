using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variados : MonoBehaviour
{
    public int numeroAleatorio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numeroAleatorio = Random.Range(0,4);
        print("El caso que se escogió fue:" + numeroAleatorio);

        switch(numeroAleatorio)
        {
            default:
                print("Encontraste un ratatata.");
                break;
            case 1:
                print("Encontraste un pikachu.");
                break;
            case 2:
                print("Encontraste un achís.");
                break;
            case 3:
                print("No encontraste nada.");
                break;
        }
    }
}
