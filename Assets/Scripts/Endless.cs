using UnityEngine;

public class Endless : MonoBehaviour {

    public GameObject start;
    public Transform player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = start.transform.position;
    }

}
