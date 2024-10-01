using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayerClearUI : MonoBehaviour
{
    //�Q�[���̃N���A�t���O�������Ă���N���X
    [SerializeField]
    ScoreChanger scoreChanger;

    //�N���A�����Ƃ��ɕ\��������UI�I�u�W�F�N�g
    [SerializeField]
    GameObject clearUI;


     void Update()
    {
       
        //�Q�[���̃N���A�����𖞂����Ă��邩���m���߂�
        if(scoreChanger.numberOfItem == 0)
        {

            //UI�p�̃I�u�W�F�N�g��\��
            clearUI.SetActive(true);
        }
    }
}
