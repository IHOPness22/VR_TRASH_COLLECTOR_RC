using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public int score = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            score++;
            Destroy(other.gameObject);
            Debug.Log("Trash Collected! Score: " + score);
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
