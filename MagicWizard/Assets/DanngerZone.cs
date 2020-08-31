using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanngerZone : MonoBehaviour
{
    [SerializeField]
    Transform JumpTo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
            collision.transform.position = JumpTo.position;
    }
}
