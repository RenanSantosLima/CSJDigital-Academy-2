using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private Animator anim;

    [SerializeField] private float speed;


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(h, v);

        if(direction.x > 0)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (direction.x < 0)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector2(0, 180);
        }

        if (direction.x == 0)
        {
            anim.SetBool("run", false);
        }

        rig.linearVelocity = direction * speed;


    }
}
