using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public int score = 0;
    public TrashSpawner spawner;
    private bool hordeSpawned = false;
    public GameTimer gameTimer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            score++;
            Destroy(other.gameObject);
            Debug.Log("Trash Collected! Score: " + score);
            if (!hordeSpawned)
            {
                hordeSpawned = true;
                spawner.SpawnHorde();
                gameTimer.StartTimer();
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
