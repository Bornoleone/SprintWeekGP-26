using TMPro;
using UnityEngine;
using UnityEngine.Events;


public class DeathMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private TextMeshProUGUI textMeshProUGUIscore;
    public UnityEvent startEvent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            startEvent.Invoke();
        }
    }
    public void UpdateHighscore()
    {
        float highscore = ScoreManager.instance.highScore;
        textMeshProUGUI.text = "Highscore is "+ highscore.ToString();
    }
    public void UpdateScore()
    {
        float score = ScoreManager.instance.previousScore;
        textMeshProUGUIscore.text = "YOUR SCORE IS " + score.ToString() + " !!!";
    }

}
