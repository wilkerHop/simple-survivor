using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public GameObject hexagonPrefab;

    public Points points;

    private float nextTimeToSpawn;

    public static Spawner Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);

            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }

    public void AddPoints()
    {
        points.points++;
    }
}
