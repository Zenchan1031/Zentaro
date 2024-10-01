using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    [SerializeField]
    ScoreChanger scoreChanger;
    void OnTriggerEnter(Collider other)
    {   
        //判定に触れたオブジェクトを消す
        Destroy(gameObject);

        //スコアも変更する
        scoreChanger.RemoveScore();
    }
}