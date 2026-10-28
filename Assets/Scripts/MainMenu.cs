using UnityEngine;

public class MainMenu : MonoBehaviour
{

    AudioSource audioSource; // Reference to the AudioSource component
    
   public void StartGame()
   {
       audioSource = GetComponent<AudioSource>();
       // Load the main game scene
       UnityEngine.SceneManagement.SceneManager.LoadScene("MainLevel");
       audioSource.Play(); // Play the audio source when starting the game
   }

   public void QuitGame()
   {
       audioSource = GetComponent<AudioSource>();
       // Quit the application
       Application.Quit();
       audioSource.Play(); // Play the audio source when quitting the game
   }
}
