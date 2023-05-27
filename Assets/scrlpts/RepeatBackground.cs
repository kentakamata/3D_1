using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピートの開始位置
    float repeatWidth;//リピートの幅
    void Start()
    {
        startPos = transform.position;//ゲーム開始時の場所を記憶
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }
    void Update()
    {
        //何か条件我満たされたら
        if(startPos.x - transform.position.x> repeatWidth) 
        {
            transform.position = startPos;//場所をリセット
        }
    }
}
