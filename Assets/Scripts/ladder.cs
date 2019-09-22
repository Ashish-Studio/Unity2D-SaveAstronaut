using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.DownArrow))
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else 
        {
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0.5f);
        }
    }
}
