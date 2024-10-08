using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeWallRotate : MonoBehaviour
{
    [SerializeField]
    [Tooltip("X軸の回転角度")]
    private float rotateX = 0;

    [SerializeField]
    [Tooltip("Y軸の回転角度")]
    private float rotateY = 0;

    [SerializeField]
    [Tooltip("Z軸の回転角度")]
    private float rotateZ = 0;

    void Update()
    {
        // X,Y,Z軸に対してそれぞれ、指定した角度ずつ回転させている。
        // deltaTimeをかけることで、フレームごとではなく、1秒ごとに回転する。
        gameObject.transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime);
    }
}
