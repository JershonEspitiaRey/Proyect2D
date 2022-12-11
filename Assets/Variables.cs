using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        vida = Random.Range(0,100);
        print("La vida es: " + vida);

        if(vida >= 60)
        {
            print("Tienes buena salud");
        }
        else if (vida < 60 && vida > 30)
        {
            print("Estás bastante herido");
        }
        else
        {
            print("Vas a morir si no te curas");
        }
    }
}
