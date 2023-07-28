using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FoodCounter : MonoBehaviour
{
    public TMP_Text text;
    public float food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = food.ToString() ;
    }
}
