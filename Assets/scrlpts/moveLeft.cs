using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    [SerializeField] float speed = 30;//ground‚ª“®‚­‘¬‚³
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
