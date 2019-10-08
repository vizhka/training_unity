
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 15f;

    public float Speed { get => speed; set => speed = value; }

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.33f ? 2.33f : mousePos.x;
            mousePos.x = mousePos.x < -2.33f ? -2.33f : mousePos.x;
            player.position = Vector2.MoveTowards
                (player.position, new Vector2(mousePos.x, player.position.y),
                Speed = Time.deltaTime);
        }

    }
}



