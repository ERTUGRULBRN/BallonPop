using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingaBalloon : MonoBehaviour
{
    public GameObject balloon;
    float bubbleCreateTime = 1f;
    float timeCounter = 0f;
    GameControl gameControl;
    void Start()
    {
        gameControl = this.gameObject.GetComponent<GameControl> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter -=Time.deltaTime;
        int factor = (int)(gameControl.timeCounter / 10) - 6;
        factor *= -1;
        if (timeCounter < 0 && gameControl.timeCounter>0)
        {
            GameObject gameObject = Instantiate(balloon, new Vector3(Random.Range(-2.5f, 2.5f), -5.75f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f*factor, 80f*factor), 0));
            timeCounter = bubbleCreateTime;
        }
    
    }
}
