using UnityEngine;

public class PlayerInputSystemMoviment : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private Vector2 moviment {get; set;}

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moviment * speed * Time.deltaTime);
    }

    public void Move(Vector2 direction)
    {
        moviment = direction;
    }
}
