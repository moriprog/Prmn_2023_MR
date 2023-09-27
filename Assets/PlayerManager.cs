using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<GameObject> touchedObjects;

    public PlayerController playerController;

    public GameObject TargetgameObject;

    public int count;

    // Start is called before the first frame update
    void Start()
    {
        // リストを初期化
        touchedObjects = new List<GameObject>();
        playerController = GetComponent<PlayerController>(); // フィールドに割り当てる
        count = 0;

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider obj)
    {
        Debug.Log("衝突");
        if (obj != null && obj.gameObject != null && count==0)
        {
            if (obj.gameObject.CompareTag("Straight"))
            {
                Debug.Log("straight反応");
                TargetgameObject.GetComponent<PlayerController>().Straight();
                count++;
            }
            else if (obj.gameObject.CompareTag("Trun Left"))
            {
                Debug.Log("Left反応");
                TargetgameObject.GetComponent<PlayerController>().Left();
                count++;
            }
            else if (obj.gameObject.CompareTag("Trun Right"))
            {
                Debug.Log("Right反応");
                TargetgameObject.GetComponent<PlayerController>().Right();
                count++;
            }
            else
            {
                Debug.Log("タグ反応なし");
            }
        }
        else
        {
            Debug.Log("CollisionオブジェクトがnullまたはgameObjectがnullです。");
        }
    }

}
