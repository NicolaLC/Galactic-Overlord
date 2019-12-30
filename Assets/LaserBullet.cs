using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour {

    [SerializeField]
    private GameObject explosionEffectPrefab;
    Rigidbody2D rb;
    private bool canMove = false;

    private void Awake () {
        rb = GetComponent<Rigidbody2D> ();
        Invoke ("Move", 2f);
        Invoke ("Destroy", 5f);
    }

    private void Move () {
        canMove = true;
    }

    private void FixedUpdate () {
        if (!canMove) {
            return;
        }
        rb.AddForce (new Vector3 (5f * Time.fixedDeltaTime, 0, 0));
    }

    private void Destroy () {
        GameObject.Destroy (gameObject);
    }

    // called when the cube hits the floor
    void OnCollisionEnter2D (Collision2D col) {
        Instantiate (explosionEffectPrefab, col.transform.position, Quaternion.identity);
        CancelInvoke ("Destroy");
        CancelInvoke ("Move");
        GameObject.Destroy (gameObject);
    }
}