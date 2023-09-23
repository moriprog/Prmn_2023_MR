using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed;
    Vector2 startPos;
    private Rigidbody rb;
    private bool isMoving = true;
    private float initialY; // 初期のy座標
    private float distanceTraveled = 0f; // 移動した距離
    public float rotationSpeed = 90f; // 回転速度（度/秒）


    // 移動速度
    public float moveSpeed = 0.145f;
    // 移動する距離
    public float moveDistance = 0.145f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
        initialY = transform.position.y; // 初期のy座標を保存
        Debug.Log("現在のy座標: " + initialY);
    }

    // Update is called once per frame
    void Update()
    {
        //Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
        //Vector3 now = rb.position;            // 座標を取得
        //now += new Vector3(0.0f, 0.005f, 0.0f);  // 前に少しずつ移動するように加算
        //rb.position = now; // 値を設定
        //Debug.Log(now.y);
        //this.speed = 0.0002f;
        //transform.Translate(0, 0, -this.speed);
        if (isMoving && distanceTraveled < moveDistance)
        {
            // x軸方向に90度回転する角速度を設定
            Vector3 targetAngularVelocity = new Vector3(0, 0, rotationSpeed);
            rb.angularVelocity = targetAngularVelocity * Mathf.Deg2Rad; // 角速度はラジアン単位で設定する必要がある

            //GetComponent<Rigidbody>().angularVelocity = new Vector3();
            // y軸方向に移動
            //Vector3 movement = new Vector3(0, moveSpeed, 0);
            //rb.MovePosition(transform.position + movement);

            // 移動した距離を更新
            //distanceTraveled += moveSpeed * Time.deltaTime;

            // 移動距離が目標距離以上になったら移動を停止
            //if (distanceTraveled >= moveDistance)
            //{
                //rb.constraints =RigidbodyConstraints.FreezeRotationY;
                //Debug.Log("停止");
                //isMoving = false;
                // Rigidbodyの速度をゼロに設定して停止させる
                //rb.velocity = Vector3.zero;
            //}
        }
    }

    void Straight()
    {
        if (isMoving && distanceTraveled < moveDistance)
        {
            // y軸方向に移動
            Vector3 movement = new Vector3(0, moveSpeed, 0);
            rb.MovePosition(transform.position + movement);

            // 移動した距離を更新
            distanceTraveled += moveSpeed * Time.deltaTime;

            // 移動距離が目標距離以上になったら移動を停止
            if (distanceTraveled >= moveDistance)
            {
                rb.constraints = RigidbodyConstraints.FreezeRotationY;
                Debug.Log("停止");
                isMoving = false;
                // Rigidbodyの速度をゼロに設定して停止させる
                rb.velocity = Vector3.zero;
            }
        }
    }

    void Right()
    {
        //Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
        Vector3 now = rb.position;            // 座標を取得
        now += new Vector3(0.0f, 0.005f,0.0f);  // 前に少しずつ移動するように加算
        rb.position = now; // 値を設定
    }

    void Left()
    {
        //Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
        Vector3 now = rb.position;            // 座標を取得
        now += new Vector3(0.0f, -0.005f, 0.0f);  // 前に少しずつ移動するように加算
        rb.position = now; // 値を設定
    }
}
