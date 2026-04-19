using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public UnityEvent OnDeathEvent;
    [SerializeField] private float previousScore;
    [SerializeField] private float currentScore;
    [SerializeField] public float highScore;
    [SerializeField] public bool gameOnGoing;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private GameObject platform;
    public static ScoreManager instance;

    void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        //RestartRun();
    }

    void Update()
    {
        if (gameOnGoing)
        {
            UpdateTimer(); 
        }
    }
    public void RestartRun()
    {
        Debug.Log("Run Started");
        SpawnStartPlatform();
        RestartTimer();
        gameOnGoing = true;
    }
    public void OnDeath()
    {
        Debug.Log("Player Died");
        RunEnded();
        previousScore = currentScore;
        if(highScore < previousScore)
        {
            highScore = previousScore;
        }
        OnDeathEvent.Invoke();
        //Time.timeScale = 0f;
    }
    private void UpdateTimer()
    {
        currentScore += Time.deltaTime;
        textMeshProUGUI.text = currentScore.ToString();
    }
    private void RestartTimer()
    {
        currentScore = 0f;
    }
    private void RunEnded()
    {
        gameOnGoing = false;
    }
    private void SpawnStartPlatform()
    {
        Instantiate(platform, new Vector3(0, -1, -18), Quaternion.identity);
    }
}
