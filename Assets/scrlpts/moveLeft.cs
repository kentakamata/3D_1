using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    [SerializeField] float speed = 30;//ground����������
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
