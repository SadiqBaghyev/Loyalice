using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float XMove;
    public int MoveSpeed;
    public float JumpForce;

    public GameObject niceJob;
    public GameObject victoryMenu;

    private void FixedUpdate()
    {
        XMove = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(XMove * MoveSpeed * 100 * Time.deltaTime, rb.velocity.y);

    }
    private void Update()
    {

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeadlyGround")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "FinishGround")
        {
            Time.timeScale = 0;
            niceJob.SetActive(true);
         victoryMenu.SetActive(false);

           

        }
     
    }
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FinishGround")
        {

            niceJob.SetActive(false);
            Time.timeScale = 1;

        }
    }
}



