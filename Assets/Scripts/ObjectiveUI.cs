using UnityEngine;
using UnityEngine.UI;

public class ObjectiveUI : MonoBehaviour
{
    [SerializeField] private Image objectiveImage; // Reference to the UI Image component

    [SerializeField] private Sprite[] objectiveSprites = new Sprite[7]; // Array to hold the objective sprites
    [SerializeField] private PresentDelivery presentDelivery; // Reference to the PresentDelivery script
    void Start()
    {

    }


    void Update()
    {
        if(presentDelivery.PresentsDelivered == 0)
        {
            objectiveImage.sprite = objectiveSprites[0]; // Display the first objective sprite
        }
        else if (presentDelivery.PresentsDelivered == 1)
        {
            objectiveImage.sprite = objectiveSprites[1]; // Display the second objective sprite
        }
        else if (presentDelivery.PresentsDelivered == 2)
        {
            objectiveImage.sprite = objectiveSprites[2]; // Display the third objective sprite
        }
        else if (presentDelivery.PresentsDelivered == 3)
        {
            objectiveImage.sprite = objectiveSprites[3]; // Display the fourth objective sprite
        }
        else if (presentDelivery.PresentsDelivered == 4)
        {
            objectiveImage.sprite = objectiveSprites[4]; // Display the fifth objective sprite
        }
        else if (presentDelivery.PresentsDelivered == 5)
        {
            objectiveImage.sprite = objectiveSprites[5]; // Display the sixth objective sprite
        }
        else if (presentDelivery.PresentsDelivered == 6)
        {
            objectiveImage.sprite = objectiveSprites[6]; // Display the seventh objective sprite
        }
    }
}
