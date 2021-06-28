using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Button jumpBtn;

    private Rigidbody2D myBody;

    private float speed = 3f;

    void Awake(){
        jumpBtn = GameObject.Find("Jump").GetComponent<Button>();
        jumpBtn.onClick.AddListener (() => Jump());
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }

    public void Jump(){
        myBody.gravityScale *= -1;
        Vector3 temp = transform.localScale;
        temp.y *= -1;
        transform.localScale = temp;
    }

} // class
