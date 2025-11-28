using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private FixedJoystick joystick;

    [SerializeField] int moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        float x = joystick.Horizontal;
        float y = joystick.Vertical;

        rb.linearVelocity = new Vector3(x, y , 0) * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
