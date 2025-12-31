using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;


    private bool isOnGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //rb.linearVelocity = Vector3.left * speed * Time.deltaTime;
            rb.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Acceleration);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isOnGrounded)
        {
            isOnGrounded = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }


    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.layer == 7)
        {
            isOnGrounded = true;
        }
    }
}
