
using UnityEngine.UI;
using UnityEngine;

public class bullet_start : MonoBehaviour
{
    public GameObject uiobj;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Bullet_player"))
        {
            uiobj.SetActive(false);
            Zmotion motion = player.GetComponent<Zmotion>();
            if (motion != null)
            {
                motion.enabled = true;
            }
            else
            {
                Debug.Log("motion script not found");
            }
        }
    }
}
