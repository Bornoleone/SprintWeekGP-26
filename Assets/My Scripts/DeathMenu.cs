using TMPro;
using UnityEngine;


public class DeathMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void UpdateHighscore()
    {
        float score = ScoreManager.instance.highScore;
        textMeshProUGUI.text = "Highscore is "+ score.ToString();
    }

}
