using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageWall : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("GameScene");  
    }
}
