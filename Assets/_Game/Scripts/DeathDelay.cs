using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDelay : MonoBehaviour
{
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Ded", delay);
    }
    void Ded()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
