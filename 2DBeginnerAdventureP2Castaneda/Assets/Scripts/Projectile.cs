using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector2 dirrection, float force)
    {
        rigidbody2d.AddForce(dirrection * force);
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Projectile Collision with");
        Destroy(gameObject);
    }
}
