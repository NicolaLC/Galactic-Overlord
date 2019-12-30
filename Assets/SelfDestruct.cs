using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {
    [SerializeField]
    private float lifeTime = 1f;
    // Start is called before the first frame update
    void Start () {
        Invoke ("Destroy", lifeTime);
    }

    private void Destroy () {
        GameObject.Destroy (gameObject);
    }
}