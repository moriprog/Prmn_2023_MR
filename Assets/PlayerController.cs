using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed;
    Vector2 startPos;
    private Rigidbody rb;
    public bool isMoving = true;
    private float initialY; // 初期のy座標
    private float distanceTraveled = 0f; // 移動した距離
    public float rotationSpeed = 90f; // 回転速度（度/秒）
    private bool isRotating = true; // 回転中かどうかを示すフラグ
    private float targetRotationAngle = 0f; // 目標の回転角度


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
        Vector3 vector = new Vector3(0,-90,-90);
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
        //if (isMoving && distanceTraveled < moveDistance && isRotating)
        {
            //isRotating = true;
            //Debug.Log("回転座標"+transform.localEulerAngles.x);
             // z軸方向に45度回転する角速度を設定
            //Vector3 targetAngularVelocity = new Vector3(0, 0, -rotationSpeed);
            //rb.angularVelocity = targetAngularVelocity * Mathf.Deg2Rad; // 角速度はラジアン単位で設定する必要がある

             // 現在の回転角度を取得
            //float currentRotationAngle = transform.rotation.eulerAngles.x;

            // 目標の回転角度（90度）に達したら回転を停止
            //if (Mathf.Abs(currentRotationAngle ) < 1.0f)
            //{ 
                 //rb.angularVelocity = Vector3.zero; // 角速度をゼロに設定して停止
                 //isRotating = false; // 回転を停止
                 //Debug.Log("回転停止");
            //}

            //GetComponent<Rigidbody>().angularVelocity = new Vector3();
            // x軸方向に移動
            //Vector3 movement = new Vector3(moveSpeed, 0, 0);
            //rb.MovePosition(transform.position + movement);

            // 移動した距離を更新
            //distanceTraveled += moveSpeed * Time.deltaTime;

            // 移動距離が目標距離以上になったら移動を停止
            //if (distanceTraveled >= moveDistance)
            //{
                //rb.constraints = RigidbodyConstraints.FreezeRotationY;
                //Debug.Log("停止");
                //isMoving = false;
                // Rigidbodyの速度をゼロに設定して停止させる
                //rb.velocity = Vector3.zero;
            //}
        }
    }

    public void Straight()
    {
        //上を向いた場合での移動
        if (isMoving && distanceTraveled < moveDistance && transform.localEulerAngles.x==90)
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
        //右を向いた場合での移動
        else if(isMoving && distanceTraveled < moveDistance && transform.rotation.x == 0.375)
        {
            // y軸方向に移動
            Vector3 movement = new Vector3(moveSpeed, 0, 0);
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
        //左を向いた場合での移動
        else if(isMoving && distanceTraveled < moveDistance && transform.rotation.x == 0.375)
        {
            // y軸方向に移動
            Vector3 movement = new Vector3(moveSpeed, 0, 0);
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
        //下を向いた場合での移動
        else if (isMoving && distanceTraveled < moveDistance && transform.localEulerAngles.x == 268.688)
        {
            // y軸方向に移動
            Vector3 movement = new Vector3(0, -moveSpeed, 0);
            rb.MovePosition(transform.position + movement);

            // 移動した距離を更新
            distanceTraveled += -moveSpeed * Time.deltaTime;

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
        else
        {
            Debug.Log("なんか違う");
        }
    }

    public void Right()
    {
        Debug.Log("Rightメソッドが呼び出された");
        if (isRotating)
        {
            Debug.Log("右回転");
            Quaternion rot = Quaternion.AngleAxis(-90, Vector3.up);
            transform.rotation *= rot;
            Debug.Log("回転停止");
        }
    }

    public void Left()
    {
        if (isRotating)
        {
            Debug.Log("左回転");
            isRotating = true;
            // z軸方向に-45度回転する角速度を設定
            Vector3 targetAngularVelocity = new Vector3(0, 0, rotationSpeed);
            rb.angularVelocity = targetAngularVelocity * Mathf.Deg2Rad; // 角速度はラジアン単位で設定する必要がある

            // 現在の回転角度を取得
            float currentRotationAngle = transform.rotation.eulerAngles.z;

            // 目標の回転角度（45度）に達したら回転を停止
            if (Mathf.Abs(currentRotationAngle ) < 1.0f)
            {
                rb.angularVelocity = Vector3.zero; // 角速度をゼロに設定して停止
                isRotating = false; // 回転を停止
                Debug.Log("回転停止");
            }
        }
    }
    public void callDebug()
    {
        Debug.Log("playerControllerの呼び出し");
    }
}
