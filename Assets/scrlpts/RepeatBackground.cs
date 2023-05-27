using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//���s�[�g�̊J�n�ʒu
    float repeatWidth;//���s�[�g�̕�
    void Start()
    {
        startPos = transform.position;//�Q�[���J�n���̏ꏊ���L��
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }
    void Update()
    {
        //���������䖞�����ꂽ��
        if(startPos.x - transform.position.x> repeatWidth) 
        {
            transform.position = startPos;//�ꏊ�����Z�b�g
        }
    }
}
