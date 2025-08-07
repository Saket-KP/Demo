
using UnityEngine;

public class quitter : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet_player")
        {
            Application.Quit();
        }
    }
}
