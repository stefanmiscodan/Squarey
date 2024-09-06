using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public void StopGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

	public void QuitToMenu() {
		SceneManager.LoadScene("Menu");
	}

	public void RestartGame() {
		SceneManager.LoadScene("Level01");
	}
}
