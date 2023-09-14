using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
        Vector3 now = rb.position;            // 座標を取得
        now += new Vector3(0.0f, 0.0f, 0.05f);  // 前に少しずつ移動するように加算
        rb.position = now; // 値を設定
        //this.speed = 0.0002f;
        //transform.Translate(0, 0, -this.speed);
    }

    void Straight()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
        Vector3 now = rb.position;            // 座標を取得
        now += new Vector3(0.0f, 0.0f, 0.05f);  // 前に少しずつ移動するように加算
        rb.position = now; // 値を設定
    }

    void Right()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
        Vector3 now = rb.position;            // 座標を取得
        now += new Vector3(0.0f, 0.005f,0.0f);  // 前に少しずつ移動するように加算
        rb.position = now; // 値を設定
    }

    void Left()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
        Vector3 now = rb.position;            // 座標を取得
        now += new Vector3(0.0f, -0.005f, 0.0f);  // 前に少しずつ移動するように加算
        rb.position = now; // 値を設定
    }
}
