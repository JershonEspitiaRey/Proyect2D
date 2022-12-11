using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamera : MonoBehaviour
{
    public Transform target;
    Camera myCam;
    // Start is called before the first frame update
    void Start()
    {
        myCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        myCam.orthographicSize = (Screen.height/800f)/0.5f;

        if(target){
            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3 (0,0, -5);
        }
    }
}
