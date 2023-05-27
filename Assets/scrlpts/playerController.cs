using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float gravityModifier;//重力値調整用
    [SerializeField] float jumpForce;//ジャンプ力
    [SerializeField] bool isOnGround;//地面についているか
    public bool gameOver;//何も書かなければprivateです
    Animator playerAnim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押されて、かつ、地面にいたら
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            //上へ力を加える
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround = false; //ジャンプした＝地面にいない
            playerAnim.SetTrigger("Jump_trig");
        }



    }
    //衝突が起きたら実行
    private void OnCollisionEnter(Collision collision)
    {
        //ぶつかった相手（collision)のタグがGroundなら
        if (collision.gameObject.CompareTag("Ground")) {
        isOnGround = true;//地面についてる状態に変更
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;//ゲームオーバーにする
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",1);
        }
    }
}
