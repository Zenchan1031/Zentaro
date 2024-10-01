using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    [SerializeField]
    ScoreChanger scoreChanger;
    void OnTriggerEnter(Collider other)
    {   
        //����ɐG�ꂽ�I�u�W�F�N�g������
        Destroy(gameObject);

        //�X�R�A���ύX����
        scoreChanger.RemoveScore();
    }
}