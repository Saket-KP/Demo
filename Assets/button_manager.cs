
using TMPro;
using UnityEngine;

public class button_manager : MonoBehaviour
{
    public GameObject player;
    public Zmotion motion;
    
    
    void Start()
    {
        motion = player.GetComponent<Zmotion>();
    }
    void Update()
    {
        
    }
   
    public void quit()
    {
        Application.Quit();
    }
}
