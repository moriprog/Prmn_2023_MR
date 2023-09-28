using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public GameObject UIgameobject;

    public AudioSource audioSource;
    private bool hasAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        UIgameobject.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj)
    {
        Debug.Log("goalmanager");
        if(obj.gameObject.name == "Player")
        {
            Debug.Log("Player衝突");
            UIgameobject.SetActive(true);

            audioSource.Play();

        }
    }
}
