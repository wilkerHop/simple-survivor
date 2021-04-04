using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float moveSpeed = 600f;

    private float movement = 0f;

    public GameObject restartButton;

    private bool alive = true;

    private void Update()
    {
        if (!alive && Input.GetKey(KeyCode.Space))
        {
            Restart();
        }

        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        alive = false;
        Time.timeScale = 0;
        restartButton.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
