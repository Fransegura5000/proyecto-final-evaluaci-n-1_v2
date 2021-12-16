using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public bool gameOver;
    private Vector3 startPos = new Vector3(0, 100, 0);

    public int score;
    public float speed = 20f;
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 40f;

    private float lim = 200f;
    private float suelo = 0f;

    public GameObject projectile;
    public GameObject recoletable;
    public GameObject obstacle;
    public GameObject shoter;

    public AudioClip shotClip;
    public AudioSource playerAudioSource;

    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI victoria;


    void Start()
    {
        
        playerAudioSource = GetComponent<AudioSource>();
        transform.position = startPos;

        gameOverText.gameObject.SetActive(false);
        victoria.gameObject.SetActive(false);
    }

    void Update()
    {
        Debug.Log(message: $"score is {score}");
        scoreText.text = $"Score {score} ";



        if (!gameOver)
        {
            //Controles
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
            transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * -verticalInput);


            if (Input.GetKeyDown(KeyCode.RightControl))
            {
              
                Instantiate(projectile, shoter.transform.position, transform.rotation);
                playerAudioSource.PlayOneShot(shotClip, 1);
            }



            //LIMITES
            if (transform.position.x <= -lim)
            {
                transform.position = new Vector3(-lim, transform.position.y, transform.position.z);
            }
            if (transform.position.x >= lim)

            {
                transform.position = new Vector3(lim, transform.position.y, transform.position.z);
            }
            if (transform.position.y <= suelo)
            {
                transform.position = new Vector3(transform.position.x, suelo, transform.position.z);
            }
            if (transform.position.y >= lim)
            {
                transform.position = new Vector3(transform.position.x, lim, transform.position.z);
            }
            if (transform.position.z <= -lim)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -lim);
            }
            if (transform.position.z >= lim)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, lim);
            }


        }

        if (score == 10)
        {
            gameOver = true;

            victoria.gameObject.SetActive(true);
        }



    }
    public void UpdateScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = $"Score {score}";


    }

    public void OnCollisionEnter(Collision otherCollider)
    {
        if (!gameOver)
        {
            if (otherCollider.gameObject.CompareTag("Good"))
            {
                Destroy(otherCollider.gameObject);

                score = score+1;
            }

            else if (otherCollider.gameObject.CompareTag("Bad"))
            {
                Destroy(gameObject);
               

                
                    gameOver = true ;
                gameOverText.gameObject.SetActive(true);

            }
        }

        

    }
}


