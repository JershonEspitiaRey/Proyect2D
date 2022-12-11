using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorUI : MonoBehaviour
{

    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Escape)){
            PausarGame();
        }

        if(Input.GetKey(KeyCode.Space)){
            ReanudarGame();
        }

    }

    public void PausarGame(){
            Time.timeScale = 0;
            canvas.SetActive(true);
    }

    public void ReanudarGame(){
            Time.timeScale = 1;
            canvas.SetActive(false);
    }

    public void salirJuego(){
        SceneManager.LoadScene("1_EscenaMenuPrincipal");
    }
}
