using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float rotationOffset;
    public Camera cam;
    public Rigidbody2D rb;
    public float dashStrenght;
    public float dashDelay;
    private float dashTimer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rotation *= Quaternion.Euler(0, 0, -90);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);


        rb.AddForce(transform.up * speed*Time.deltaTime);
        if (dashTimer >= dashDelay)
        {
            if (Input.GetMouseButtonDown(0)) {
                rb.AddForce(transform.up * dashStrenght);
                dashTimer = 0f;
            } 
        }
        else
        {
            dashTimer += Time.deltaTime;
        }
        if (dashStrenght!=0)
        {
            GameObject dashUI = GameObject.FindGameObjectWithTag("Dash");
            if (dashUI != null)
            {
                dashUI.GetComponent<Image>().fillAmount = dashTimer / dashDelay;
            }
        }
    }
}
