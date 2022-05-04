using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject blood;

    void Update()
    {
        if(transform.position.x > 20)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > 20)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Zombie(Clone)")
        {
            Instantiate(blood, transform.position, transform.rotation);
            other.GetComponent<Zombie>().hp -= 2;
            Destroy(gameObject);
        }
        if (other.name == "walls")
        {
            Destroy(gameObject);
        }
    }
    
}