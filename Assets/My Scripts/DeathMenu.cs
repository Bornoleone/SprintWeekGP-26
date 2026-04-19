using TMPro;
using UnityEngine;
using UnityEngine.Events;


public class DeathMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
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
        float score = ScoreManager.instance.highScore;
        textMeshProUGUI.text = "Highscore is "+ score.ToString();
    }

}
