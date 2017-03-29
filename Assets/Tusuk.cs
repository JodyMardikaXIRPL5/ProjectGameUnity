using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tusuk : MonoBehaviour {

    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {
        if (!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bola")
        {
            transform.SetParent(col.transform);
            col.GetComponent<Rotator>().speed += 7f;
            isPinned = true;
        } else if (col.tag == "Pin")
        {
            FindObjectOfType<Gameplay>().EndGame();
        }
    }

}
