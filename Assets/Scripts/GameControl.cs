using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public UnityEngine.UI.Text bubbletext, timetext;
    public GameObject explosion;
    public float timeCounter = 60f;
    int bubblepop = 0;
    void Start()
    {
        bubbletext.text = "Bubble Pop: " + bubblepop;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCounter > 0)
        {
            timeCounter -= Time.deltaTime;
            timetext.text = "Time : " + (int)timeCounter;
        }else
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("BUBBLE");
            for (int i = 0; i < gameObjects.Length; i++)
            {
                Instantiate(explosion, gameObjects[i].transform.position, gameObjects[i].transform.rotation);
                Destroy(gameObjects[i]);
            }
        }
        
    }
    public void BubbleAdd()
    {
        bubblepop += 1;
        bubbletext.text = "Bubble Pop: " + bubblepop;
    }

}

