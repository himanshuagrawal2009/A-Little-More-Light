 using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float horizontalInput;
    float verticalInput;
    float speed = 5.0f;
    [SerializeField] private Animator animator; // Reference to the Animator component


    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * Time.deltaTime * speed, 0, verticalInput * Time.deltaTime * speed);
        animator.speed = (horizontalInput != 0 || verticalInput != 0) ? 1f : 0f;
    }

}
