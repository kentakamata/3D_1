using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    [SerializeField] float speed = 30;//groundが動く速さ
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
