using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//���s�[�g�̊J�n�ʒu
    void Start()
    {
        startPos = transform.position;//�Q�[���J�n���̏ꏊ���L��
    }
    void Update()
    {
        //���������䖞�����ꂽ��
        if(startPos.x - transform.position.x> 10.0f) {
            transform.position = startPos;//�ꏊ�����Z�b�g
        }
    }
}
