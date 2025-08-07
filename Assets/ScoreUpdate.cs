using TMPro;

using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    public Zmotion ScoreRef;
    public TextMeshProUGUI ScoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ScoreText.text = $"Your Score : {ScoreRef.score:F2}";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = $"Your Score : {ScoreRef.score:F2}";
    }
}
