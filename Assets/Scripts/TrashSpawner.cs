using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab;
    public Transform[] spawnPoints;
    public int amountToSpawn = 10;

    public void SpawnHorde()
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);

            Instantiate(
                trashPrefab,
                spawnPoints[randomIndex].position,
                Quaternion.identity
            );

        }
    }
}
