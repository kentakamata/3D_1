using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float gravityModifier;//�d�͒l�����p
    [SerializeField] float jumpForce;//�W�����v��
    [SerializeField] bool isOnGround;//�n�ʂɂ��Ă��邩
    public bool gameOver;//���������Ȃ����private�ł�
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
        //�X�y�[�X�L�[��������āA���A�n�ʂɂ�����
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            //��֗͂�������
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround = false; //�W�����v�������n�ʂɂ��Ȃ�
            playerAnim.SetTrigger("Jump_trig");
        }



    }
    //�Փ˂��N��������s
    private void OnCollisionEnter(Collision collision)
    {
        //�Ԃ���������icollision)�̃^�O��Ground�Ȃ�
        if (collision.gameObject.CompareTag("Ground")) {
        isOnGround = true;//�n�ʂɂ��Ă��ԂɕύX
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;//�Q�[���I�[�o�[�ɂ���
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",1);
        }
    }
}
