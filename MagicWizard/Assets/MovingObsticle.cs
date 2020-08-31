using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObsticle : MonoBehaviour
{
    [SerializeField]
    Transform[] path;
    int current = 0;
    int increase = -1;

    [SerializeField]
    float speed = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Mathf.Abs(transform.position.x - path[current].transform.position.x) < .1f 
            && Mathf.Abs(transform.position.y - path[current].transform.position.y) < .1f)
        {
            if(current == path.Length - 1)
            {
                increase = increase * -1;
            }
            else if (current == 0)
            {
                increase = increase * -1;
            }

            current += increase;
            Debug.Log(current);
        }
        float step = speed * Time.deltaTime;
        //gameObject.transform.LookAt(path[current]);
        gameObject.transform.position = Vector2.MoveTowards(transform.position, path[current].position, step);
    }
}
