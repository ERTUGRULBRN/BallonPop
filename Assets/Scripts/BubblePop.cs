using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePop : MonoBehaviour
{
    public GameObject explosion;
    GameControl gameControl;
    void Start()
    {
        gameControl = GameObject.Find("ballonCreateScripts").GetComponent<GameControl>();
    }
   void OnMouseDown()
    {
        GameObject gameObject = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(gameObject, 0.450f);
        gameControl.BubbleAdd();
    }
}
