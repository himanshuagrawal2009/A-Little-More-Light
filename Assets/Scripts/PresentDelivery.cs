using UnityEngine;
using UnityEngine.SceneManagement;

public class PresentDelivery : MonoBehaviour
{
    public int PresentsDelivered = 0; 
    bool[] HousesDelivered = new bool[6]; // Assuming 6 houses
    [SerializeField] GameObject[] Presents = new GameObject[6]; // Assuming 6 presents
    [SerializeField] AudioSource audioSource; // Reference to the AudioSource component
    [SerializeField] AudioClip PresentDeliverySFX, BackgroundMusic; // Reference to the delivery sound and background music clips
    [SerializeField] private GameObject EndGameScreen; // Reference to the end game screen sprite
    void Start()
    {
        audioSource.clip = BackgroundMusic; // Set the background music clip
        audioSource.loop = true; // Make the background music loop
        audioSource.Play(); // Play the background music       
    }

    
    void Update()
    {
       
       PresentDeliveryLogic();
    }

    void PresentDeliveryLogic()

    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5))
            {  
                if (hit.collider.CompareTag("House1") && !HousesDelivered[0])
                {
                    HousesDelivered[0] = true;
                    Presents[0].SetActive(true); // Activate the present for House1
                    PresentsDelivered++;
                    Debug.Log("Present Delivered: " + PresentsDelivered);
                    audioSource.PlayOneShot(PresentDeliverySFX); // Play the delivery sound
                }
                else if (hit.collider.CompareTag("House2") && !HousesDelivered[1])
                {
                    HousesDelivered[1] = true;
                    Presents[2].SetActive(true); // Activate the present for House2
                    PresentsDelivered++;
                    Debug.Log("Present Delivered: " + PresentsDelivered);
                    audioSource.PlayOneShot(PresentDeliverySFX); // Play the delivery sound
                }
                else if (hit.collider.CompareTag("House3") && !HousesDelivered[2])
                {
                    HousesDelivered[2] = true;
                    Presents[1].SetActive(true); // Activate the present for House3
                    PresentsDelivered++;
                    Debug.Log("Present Delivered: " + PresentsDelivered);
                    audioSource.PlayOneShot(PresentDeliverySFX); // Play the delivery sound
                }
                else if (hit.collider.CompareTag("House4") && !HousesDelivered[3])
                {
                    HousesDelivered[3] = true;
                    Presents[3].SetActive(true); // Activate the present for House4
                    PresentsDelivered++;
                    Debug.Log("Present Delivered: " + PresentsDelivered);
                    audioSource.PlayOneShot(PresentDeliverySFX); // Play the delivery sound
                }
                else if (hit.collider.CompareTag("House5") && !HousesDelivered[4])
                {
                    HousesDelivered[4] = true;
                    Presents[4].SetActive(true); // Activate the present for House5
                    PresentsDelivered++;
                    Debug.Log("Present Delivered: " + PresentsDelivered);
                    audioSource.PlayOneShot(PresentDeliverySFX); // Play the delivery sound
                }
                else if (hit.collider.CompareTag("House6") && !HousesDelivered[5])
                {
                    HousesDelivered[5] = true;
                    Presents[5].SetActive(true); // Activate the present for House6
                    PresentsDelivered++;
                    Debug.Log("Present Delivered: " + PresentsDelivered);
                    audioSource.PlayOneShot(PresentDeliverySFX); // Play the delivery sound
                }
                else
                {
                    Debug.Log("Already delivered to this house");
                }
            }
        }

        if (PresentsDelivered == 6)
        {
            EndGameScreen.SetActive(true); // Show the end game screen      
        }
    }
}
