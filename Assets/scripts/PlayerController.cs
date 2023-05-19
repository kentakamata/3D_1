using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 20; //
    public Text scoreText; //
    public Text winText;

    private Rigidbody rb;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        score = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        var moveHorizonteal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizonteal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;

            SetCountText();
        }
    }
    void SetCountText()
    {
        scoreText.text = "Count:" + score.ToString();
        if (score >= 13)
        {
            winText.text = "You Win!";
        }
    }
}