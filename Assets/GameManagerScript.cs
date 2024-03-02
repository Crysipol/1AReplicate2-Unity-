using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
   
    public GameObject bomb;
    public GameObject explosionPrefab;
    public int BombHealth;

    // Start is called before the first frame update
    void Start()
    {
        BombHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BombHealth -= 1;
            if (BombHealth ==0)
            {
                GetComponent<AudioSource>().Play();
                Instantiate(explosionPrefab);
                Destroy(bomb);
                Debug.Log("Destroyed");
            }
          
        }
    }
}
