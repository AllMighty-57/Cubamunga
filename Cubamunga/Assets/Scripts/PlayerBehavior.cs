using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody rb;

    public TMP_Text changingColorText;
    public float redVal; 
    public float greenVal;
    public float blueVal;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        if(rb.position.y < -1f)
        {
            forwardForce = 0f;
            sidewaysForce = 0f;
            FindAnyObjectByType<GameManager>().endGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Object hit");
            forwardForce = 0f;
            sidewaysForce = 0f;
            changingColorText.color = new Color( redVal/ 255f, greenVal/ 255f, blueVal/ 255f, 1f);

            FindAnyObjectByType<GameManager>().endGame();
        }
    }
}
