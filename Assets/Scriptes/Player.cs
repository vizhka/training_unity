using UnityEngine;

public class Player : MonoBehaviour {
    public static bool lose = false;
    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Bomb")
            lose = true;
    }
}
