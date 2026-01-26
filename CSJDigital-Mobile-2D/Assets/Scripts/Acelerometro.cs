using UnityEngine;

public class Acelerometro : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.Translate(Input.acceleration.x * speed, 0, -Input.acceleration.z * speed);
    }
}
