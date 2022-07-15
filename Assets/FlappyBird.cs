using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    public Rigidbody2D rg;
    public GameObject gameOverObj;
    public float speed;
    private void Start()
    {
        Time.timeScale = 1; 
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)|| Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector2.up * speed);
        }
    } 
    private void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // GameOver();
    }
}
