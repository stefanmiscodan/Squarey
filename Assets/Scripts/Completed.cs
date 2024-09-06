using UnityEngine;
using UnityEngine.SceneManagement;

public class Completed : MonoBehaviour
{
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 7);
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartEverything()
    {
        SceneManager.LoadScene("Level01");
    }
}
