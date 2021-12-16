using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPos : MonoBehaviour
{
    private Vector3 spawnPos;

    private int limit = 200;
    private int limit2 = 0;


    // Start is called before the first frame update
    void Start()
    {



        int randomPosX = Random.Range(-limit, limit); // Genera un numero aleatorio entre 0 y el numero 199
        int randomPosY = Random.Range(limit2, limit);
        int randomPosZ = Random.Range(-limit, limit);

        spawnPos = new Vector3(randomPosX, randomPosY, randomPosZ);

        transform.position = spawnPos;



    }

    // Update is called once per frame
    void Update()
    {
        




    }
}
