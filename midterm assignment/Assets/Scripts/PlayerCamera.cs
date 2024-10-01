using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;
    Vector3 playerPosition;

    Vector3 offset;

    void Start()
    {
        playerPosition = playerTransform.position;
        offset = gameObject.transform.position - playerPosition;
    }

    void FixedUpdate()
    {
        playerPosition = playerTransform.position;
        gameObject.transform.position = playerPosition + offset;
    }
}
