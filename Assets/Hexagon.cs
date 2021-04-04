using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;

    public float shrinkSpeed = 3f;

    private bool addedPoints;

    private void Start()
    {
        rb.rotation = Random.Range(0, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    private void Update()
    {
        transform.localScale -= Vector3.one * (shrinkSpeed * Time.deltaTime);

        if (!addedPoints && transform.localScale.x < 1f)
        {
            addedPoints = true;

            Spawner.Instance.AddPoints();
        }

        if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        }
    }
}
