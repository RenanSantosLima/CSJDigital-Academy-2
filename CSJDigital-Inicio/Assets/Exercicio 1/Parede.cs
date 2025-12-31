using UnityEngine;

public class Parede : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }
}
