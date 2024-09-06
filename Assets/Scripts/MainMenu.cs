using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	void Start() {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	public void PlayGame () 
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame() {
		Application.Quit ();
	}
    
    public void EndlessMode()
    {
        SceneManager.LoadScene("Endless");
    }

    public void PlayVR()
    {
        SceneManager.LoadScene("VR");
    }
}
