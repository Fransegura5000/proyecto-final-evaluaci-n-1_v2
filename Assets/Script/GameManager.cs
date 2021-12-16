using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    private PlayerController playerControllerScript;

    public GameObject[] obstaclePrefabs;

    private Vector3 spawnPos;

    private float startDelay = 1.0f;
    private float repeatRate = 1.0f;

    private int limit = 200;
    private int limit2 = 0;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);





    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {

        if (!playerControllerScript.gameOver) // Siempre y cuando no estemos muertos,
        {
            int randomPosX = Random.Range(-limit, limit); // Genera un numero aleatorio entre 0 y el numero 199
            int randomPosY = Random.Range(limit2, limit);
            int randomPosZ = Random.Range(-limit, limit);

            spawnPos = new Vector3(randomPosX, randomPosY, randomPosZ);

            Instantiate(obstaclePrefabs[0], spawnPos, obstaclePrefabs[0].transform.rotation); //Genera el objeto (y de donde lo sacamos), en la posición que hemos elegido, y con la rotación de cada objeto.
        }


    }



}
