using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private PlayerController playerControllerScript;


    private void OnTriggerEnter(Collider otherTrigger)
    {
       

        if (gameObject.CompareTag("Good"))
        {
            



        }


        if (gameObject.CompareTag("Bad"))
        {
            Destroy(gameObject);




        }


    }

}

