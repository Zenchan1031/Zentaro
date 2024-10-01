using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    [SerializeField]
    [Tooltip("X²‚Ì‰ñ“]Šp“x")]
    private float rotateX = 0;

    [SerializeField]
    [Tooltip("Y²‚Ì‰ñ“]Šp“x")]
    private float rotateY = 0;

    [SerializeField]
    [Tooltip("Z²‚Ì‰ñ“]Šp“x")]
    private float rotateZ = 0;
    
    void Update()
    {
     // X,Y,Z²‚É‘Î‚µ‚Ä‚»‚ê‚¼‚êAw’è‚µ‚½Šp“x‚¸‚Â‰ñ“]‚³‚¹‚Ä‚¢‚éB
     // deltaTime‚ğ‚©‚¯‚é‚±‚Æ‚ÅAƒtƒŒ[ƒ€‚²‚Æ‚Å‚Í‚È‚­A1•b‚²‚Æ‚É‰ñ“]‚·‚éB
     gameObject.transform.Rotate(new Vector3 (rotateX, rotateY, rotateZ) * Time.deltaTime);
    }
}
