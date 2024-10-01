using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayerClearUI : MonoBehaviour
{
    //ゲームのクリアフラグを持っているクラス
    [SerializeField]
    ScoreChanger scoreChanger;

    //クリアしたときに表示させるUIオブジェクト
    [SerializeField]
    GameObject clearUI;


     void Update()
    {
       
        //ゲームのクリア条件を満たしているかを確かめる
        if(scoreChanger.numberOfItem == 0)
        {

            //UI用のオブジェクトを表示
            clearUI.SetActive(true);
        }
    }
}
