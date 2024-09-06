using UnityEngine.SceneManagement;
using UnityEngine;

public class ToMenu : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Menu");
    }
}
