using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //面倒なのでprivateは省略してます
    [SerializeField] GameObject obstaclePrefab;//障害物プレハブ
    Vector3 spawnPos = new Vector3(25,0,0);//スポーンする場所
    float elapsedTime;//経過時間
    playerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();
    }

    void Update()
    {
        elapsedTime +=Time.deltaTime;//毎Fの時間を足していく

        if(elapsedTime > 2.0f && !playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab,spawnPos,obstaclePrefab.transform.rotation);
            elapsedTime = 0.0f;//経過時間リセット
        }
    }
}
