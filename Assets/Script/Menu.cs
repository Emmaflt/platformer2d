using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    public void StartGame() {
        SceneManager.LoadScene("Niv1");
    }

    public void OpenOptions() {
        Debug.Log("Options menu opened"); 
    }

    public void QuitGame() {
        Debug.Log("Quitter le jeu !");
        Application.Quit();
    }
}
