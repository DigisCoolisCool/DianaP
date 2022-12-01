using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainscript : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public AudioSource coinmusic;
    public Text scoreText;
    public GameObject winText;
    void Start()
    {
     scoreText.text = "Score: " + score;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = "Score: " + score;
            //coinmusic.Play();

            if (collision.gameObject.tag == "danger")
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "finish")
        {
            winText.SetActive(true);
        }
    }

  
}













