using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador_UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarJuego(){
        SceneManager.LoadScene("2_EscenaMapaPrincipal");
    }

    public void cerrarJuego(){
        Application.Quit();
    }
}
