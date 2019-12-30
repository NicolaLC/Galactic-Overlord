using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {
    [SerializeField]
    private float fireRate = 1f;

    [SerializeField]
    private float damage = 1f;

    [SerializeField]
    private float health = 1f;

    [SerializeField]
    private GameObject shootPoint;

    [SerializeField]
    private GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start () {
        /// TODO: register on parent ship as component of the ship
        InvokeRepeating ("Shoot", 1f / fireRate, 1f / fireRate);
    }

    private void Shoot () {
        Instantiate (bulletPrefab, shootPoint.transform.position, Quaternion.identity);
    }
}