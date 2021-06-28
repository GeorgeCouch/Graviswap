using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    private Button PlayButtonB;

    public AudioSource PlayButtonPP;

    public void PlayButtonS(){
        PlayButtonPP.Play();
    }

    public void Awake(){
        PlayButtonB = GameObject.Find("PlayButtonP").GetComponent<Button>();
        PlayButtonB.onClick.AddListener (() => PlayButtonS());
    }
}
