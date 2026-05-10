using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public TMP_Text timerText;
    private bool timerRunning = false;

    public void StartTimer()
    {
        timerRunning = true;
        timerText.gameObject.SetActive(true);
    }

    void Start()
    {
        timerText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (!timerRunning) return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(timeRemaining / 60);
            int seconds = Mathf.FloorToInt(timeRemaining % 60);

            timerText.text = minutes + ":" + seconds.ToString("00");
        }
        else
        {
            timerText.text = "TIME UP";
            timerRunning = false;
        }
    }
}
