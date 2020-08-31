using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllertest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Jump") > 0)
        {
            Debug.Log("Jump");
        }
        if (Input.GetAxis("Fire1") > 0)
        {
            Debug.Log("Fire1");
        }
        if (Input.GetAxis("Fire2") > 0)
        {
            Debug.Log("Fire2");
        }
        if (Input.GetAxis("Fire3") > 0)
        {
            Debug.Log("Fire3");
        }
    }
}
