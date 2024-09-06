using UnityEngine;

public class Level6 : MonoBehaviour
{
    public GameObject toActivate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        toActivate.gameObject.SetActive(true);
    }

}
