using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour
{
    [SerializeField] private float forceMag = 10;
   
    public void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("collided!");
        if (other.gameObject.tag == "Player") {
            Rigidbody2D playerBody = other.gameObject.GetComponent<Rigidbody2D>();
            Vector2 forceApplied = new Vector2(/*-1 * playerBody.velocity.normalized.x **/ forceMag, /*-1 * playerBody.velocity.normalized.y **/ forceMag);
            playerBody.AddForce(forceApplied, ForceMode2D.Impulse);
        }
    }
}