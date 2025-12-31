using UnityEngine;

public class PlayerTiro : MonoBehaviour
{
    [SerializeField] private GameObject projetil;
    [SerializeField] private GameObject spawnPoint;


    [SerializeField] private float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject bullet = Instantiate(projetil);
            bullet.transform.position = spawnPoint.transform.position;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
        }
    }

}
