using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueGround : MonoBehaviour
{
    private GameController gameController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameController.CompleteLevel();
        }
    }
}
