using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private Text scoreText;
    private int score = 0;
    public AudioSource CoinPickup;
    public AudioSource Death;
    public AudioSource EnemyDeath;
    public AudioSource SpikeDeath;

    public void PlayCoinPickup(){
        CoinPickup.Play();
    }
    public void PlayDeath(){
        Death.Play();
    }
    public void PlayEnemyDeath(){
        EnemyDeath.Play();
    }
    public void PlaySpikeDeath(){
        SpikeDeath.Play();
    }

    void Awake ()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text> ();
        scoreText.text = "0";
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Coin"){
            score++;
            PlayCoinPickup();
            scoreText.text = score.ToString();
            target.gameObject.SetActive(false);
        }

        //Delete Enemy
        if(target.tag == "Rocket" || target.tag == "SpikeMonsterA" || target.tag == "SpikeMonsterB"
        || target.tag == "UFO" || target.tag == "UFOFast" || target.tag == "BlueAlien" || target.tag == "RedAlien" || target.tag == "SkullUFO"){
            if(target.tag == "Rocket" || target.tag == "UFO" || target.tag == "UFOFast" || target.tag == "BlueAlien" || target.tag == "RedAlien" || target.tag == "SkullUFO"){
                PlayEnemyDeath();
            } else
            {
                PlayDeath();
            }
            transform.position = new Vector3 (0, 1000, 0);
            target.gameObject.SetActive (false);
            StartCoroutine (RestartGame());
        }

        //Enemy Stays
        if(target.tag == "FloorSpike" || target.tag == "CeilingSpike"){
            PlaySpikeDeath();
            transform.position = new Vector3 (0, 1000, 0);
            //target.gameObject.SetActive (false);
            StartCoroutine (RestartGame());
        }

        IEnumerator RestartGame() {
            yield return new WaitForSecondsRealtime (2f);
            SceneManager.LoadScene (SceneManager.GetActiveScene().name);
        }
    }
}
