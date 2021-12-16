using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 40f;
    private float lim = 350f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

       if (transform.position.x <= -lim)
        {
            Destroy(gameObject);
        }
        if (transform.position.x >= lim)

        {
            Destroy(gameObject);
        }
        if (transform.position.y <= -lim)
        {
            Destroy(gameObject);
        }
        if (transform.position.y >= lim)
        {
            Destroy(gameObject);
        }
        if (transform.position.z <= -lim)
        {
            Destroy(gameObject);
        }
        if (transform.position.z >= lim)
        {
            Destroy(gameObject);
        }
     

    }
}
