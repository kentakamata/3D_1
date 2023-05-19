
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllr : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(player.transform.position - transform.position):
    }
}