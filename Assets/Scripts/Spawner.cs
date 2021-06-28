using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] items;
    public GameObject[] coin;

    private float minY = -3.7f, maxY = 3.7f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (SpawnItems(1f));
        StartCoroutine (SpawnCoin(1f));
    }

    IEnumerator SpawnItems(float time) {
        yield return new WaitForSeconds (time);
        int currentItem = Random.Range(0, items.Length);
        Vector3 temp = new Vector3 (transform.position.x, Random.Range(minY, maxY), 0);
        if(currentItem == 2){
            temp = new Vector3 (transform.position.x, Random.Range(3.2f, 3.2f), 0);
        } else if(currentItem == 5)
        {
            temp = new Vector3 (transform.position.x, Random.Range(-3.2f, -3.2f), 0);
        } else if(currentItem == 3)
        {
            temp = new Vector3 (transform.position.x, Random.Range(-3.69f, -3.69f), 0);
        } else if(currentItem == 4)
        {
            temp = new Vector3 (transform.position.x, Random.Range(3.79f, 3.79f), 0);
        } else if(currentItem == 9){
            temp = new Vector3 (transform.position.x, Random.Range(-3.44f, -3.44f), 0);
        } else if(currentItem == 10){
            temp = new Vector3 (transform.position.x, Random.Range(3.44f, 3.44f), 0);
        }
        Instantiate (items[currentItem], temp, Quaternion.identity);
        StartCoroutine (SpawnItems(Random.Range(1f, 2f)));
    }

    IEnumerator SpawnCoin(float time){
        yield return new WaitForSeconds(time);
        Vector3 temp = new Vector3 (transform.position.x, Random.Range(minY, maxY), 0);
        Instantiate (coin[0], temp, Quaternion.identity);
        StartCoroutine (SpawnCoin(Random.Range(1f, 2f)));
    }
}
