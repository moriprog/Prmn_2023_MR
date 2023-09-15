using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<GameObject> touchedObjects;

    // Start is called before the first frame update
    void Start()
    {
        // リストを初期化
        touchedObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトがタグ別に処理される
        foreach (GameObject obj in touchedObjects)
        {
            if (obj.CompareTag("Stright"))
            {
                // Strightタグの処理
                Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
                //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
                Vector3 now = rb.position;            // 座標を取得
                now += new Vector3(0.0f, 0.0f, 0.05f);  // 前に少しずつ移動するように加算
                rb.position = now; // 値を設定
                Debug.Log("Strightオブジェクトを処理します");
            }
            else if (obj.CompareTag("Lift"))
            {
                // Liftタグの処理
                Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
                //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
                Vector3 now = rb.position;            // 座標を取得
                now += new Vector3(0.0f, 0.05f, 0.0f);  // 前に少しずつ移動するように加算
                rb.position = now; // 値を設定
                Debug.Log("Liftオブジェクトを処理します");
            }
            else if (obj.CompareTag("Right"))
            {
                // Rightタグの処理
                Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
                //rb.constraints = RigidbodyConstraints.FreezeRotationX.None; //Rotaitionのxをオン
                Vector3 now = rb.position;            // 座標を取得
                now += new Vector3(0.0f, -0.005f, 0.0f);  // 前に少しずつ移動するように加算
                rb.position = now; // 値を設定
                Debug.Log("Rightオブジェクトを処理します");
            }
        }
    }
}
