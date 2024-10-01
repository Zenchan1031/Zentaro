using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// プレイヤーの移動処理
public class PlayerMove : MonoBehaviour
{
    // 移動速度
    [SerializeField]
    float moveSpeed;

    // X方向にかける力
    float addForceX;
    // Z方向に書ける力
    float addForceZ;

    // 物理演算をスクリプトで利用する
    Rigidbody rigidBody;

    void Start()
    {
        // リジッドボディの機能を取得
        rigidBody = GetComponent<Rigidbody>();

        // 個々に数値が入ると動くので未入力は0
        addForceX = 0;
        addForceZ = 0;
    }

    void Update()
    {
        // GetAxisという機能を使って移動の力を取得する
        addForceX = Input.GetAxis("Horizontal") * moveSpeed;
        addForceZ = Input.GetAxis("Vertical") * moveSpeed;
    }

    void FixedUpdate()
    {
        // 実際に力を加える
        rigidBody.AddForce(addForceX, 0, addForceZ);
    }
}
