using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float horizontalInput;
    float verticalInput;
    float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * Time.deltaTime * speed, 0, verticalInput * Time.deltaTime * speed);
    }

}
