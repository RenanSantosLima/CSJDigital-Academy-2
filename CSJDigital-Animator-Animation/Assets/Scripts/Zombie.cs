using UnityEngine;

public class Zombie : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private float speed;

    private Vector2 direction;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), transform.position.y);

        if(direction.x != 0)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("attack");
        }

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = direction * speed;
    }
    







}
