using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピートの開始位置
    void Start()
    {
        startPos = transform.position;//ゲーム開始時の場所を記憶
    }
    void Update()
    {
        //何か条件我満たされたら
        if(startPos.x - transform.position.x> 10.0f) {
            transform.position = startPos;//場所をリセット
        }
    }
}
