using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEat : MonoBehaviour
{
    public float healingFactor;
    public float food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="CollisionPod")
        {
            GameObject.FindObjectOfType<FoodCounter>().food += food;
            if (GameObject.FindObjectOfType<PlayerHealth>().health + healingFactor<= GameObject.FindObjectOfType<PlayerHealth>().maxHealth )
            {
                GameObject.FindObjectOfType<PlayerHealth>().health += healingFactor;
            }
            else
            {
                GameObject.FindObjectOfType<PlayerHealth>().health = GameObject.FindObjectOfType<PlayerHealth>().maxHealth;
            }
           
            Destroy(gameObject);
           
        }
    }
}
