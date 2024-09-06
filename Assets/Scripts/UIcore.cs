using UnityEngine.SceneManagement;
using UnityEngine;

public class UIcore : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartButton()
    {
        Application.Quit();
    }
}
