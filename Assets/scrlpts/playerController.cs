using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float gravityModifier;//�d�͒l�����p
    [SerializeField] float jumpForce;//�W�����v��
    [SerializeField] bool isOnGround;//�n�ʂɂ��Ă��邩
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�L�[��������āA���A�n�ʂɂ�����
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //��֗͂�������
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround = false; //�W�����v�������n�ʂɂ��Ȃ�
        }

    }
    //�Փ˂��N��������s
    private void OnCollisionEnter(Collision collision)
    {
        //�Ԃ���������icollision)�̃^�O��Ground�Ȃ�
        if (collision.gameObject.CompareTag("Ground")) {
        isOnGround = true;//�n�ʂɂ��Ă��ԂɕύX
        }
    }
}
