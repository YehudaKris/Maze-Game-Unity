using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour  
{

    private float speed = 5.0f;
    private float pushback = 8.0f;
    public Text youWin;
    public Text welcome;
    public AudioSource src;
    public AudioClip playersound;

    void Start()
    {
        welcome.text = " Quick He's About to Explode Help Him Find His Way Home \n control : W,A,S,D";

    }
    void control()
    {
        src.clip = playersound;
        src.Play();
    }
    

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed* Time.deltaTime, 0, 0);
            welcome.text = "";
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate( 0, speed* Time.deltaTime, 0);
            welcome.text = "";
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            welcome.text = "";
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed* Time.deltaTime, 0, 0);
            welcome.text = "";
        }
        
         if (Input.GetKey(KeyCode.F))
            {
                restart();
            }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
         void restart()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "home")
        {
            youWin.text = "YOU EXPLODED!!! \n\n press F to Reset \n\n Esc to Quit";

        }


        if(collision.gameObject.tag == "Walls")
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(0, 0, 0);
            }
        }
    }
}
