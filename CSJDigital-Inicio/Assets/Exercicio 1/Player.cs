using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }

    }
}
