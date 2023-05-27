using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //�ʓ|�Ȃ̂�private�͏ȗ����Ă܂�
    [SerializeField] GameObject obstaclePrefab;//��Q���v���n�u
    Vector3 spawnPos = new Vector3(25,0,0);//�X�|�[������ꏊ
    float elapsedTime;//�o�ߎ���
    playerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();
    }

    void Update()
    {
        elapsedTime +=Time.deltaTime;//��F�̎��Ԃ𑫂��Ă���

        if(elapsedTime > 2.0f && !playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab,spawnPos,obstaclePrefab.transform.rotation);
            elapsedTime = 0.0f;//�o�ߎ��ԃ��Z�b�g
        }
    }
}
