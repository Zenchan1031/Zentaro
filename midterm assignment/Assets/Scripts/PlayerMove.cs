using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �v���C���[�̈ړ�����
public class PlayerMove : MonoBehaviour
{
    // �ړ����x
    [SerializeField]
    float moveSpeed;

    // X�����ɂ������
    float addForceX;
    // Z�����ɏ������
    float addForceZ;

    // �������Z���X�N���v�g�ŗ��p����
    Rigidbody rigidBody;

    void Start()
    {
        // ���W�b�h�{�f�B�̋@�\���擾
        rigidBody = GetComponent<Rigidbody>();

        // �X�ɐ��l������Ɠ����̂Ŗ����͂�0
        addForceX = 0;
        addForceZ = 0;
    }

    void Update()
    {
        // GetAxis�Ƃ����@�\���g���Ĉړ��̗͂��擾����
        addForceX = Input.GetAxis("Horizontal") * moveSpeed;
        addForceZ = Input.GetAxis("Vertical") * moveSpeed;
    }

    void FixedUpdate()
    {
        // ���ۂɗ͂�������
        rigidBody.AddForce(addForceX, 0, addForceZ);
    }
}
