using System.Collections;
using UnityEngine;
public class SpawnBombs : MonoBehaviour {
    public GameObject bomb;
    void Start(){
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn () {
        while (true)
        {
            Instantiate (bomb, new Vector2 (Random.Range (-2.33f, 2.33f), 5.19f), Quaternion.identity);
            yield return new WaitForSeconds (1.2f);
        }
    }
    }
