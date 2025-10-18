using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject endPanel;
    private string Enemy = "Enemy";

    public bool False { get; private set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Enemy)
        {
            endPanel.SetActive(true);
            gameObject.SetActive(false);     
        }
    }

}
