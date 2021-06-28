using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private float width = 0f;

    // Use this for initialization
    void Awake(){
        width = GameObject.Find("BG").GetComponent<BoxCollider2D> ().size.x;

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D target){
        if(target.tag == "Coin" || target.tag == "BG" || target.tag == "Ground"){
            Vector3 temp = target.transform.position;
            temp.x += width * 3;
            target.transform.position = temp;
        }
        if (target.tag == "Coin" || target.tag == "Rocket" || target.tag == "FloorSpike" || 
        target.tag == "CeilingSpike" || target.tag == "SpikeMonsterA" || target.tag == "SpikeMonsterB"
        || target.tag == "UFO" || target.tag == "UFOFast" || target.tag == "BlueAlien" || target.tag == "RedAlien" || target.tag == "SkullUFO"){
            target.gameObject.SetActive(false);
        }
    }
} // class














