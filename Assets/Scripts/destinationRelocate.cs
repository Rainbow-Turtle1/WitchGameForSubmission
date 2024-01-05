using UnityEngine;

public class DestinationRelocate : MonoBehaviour
{
    [SerializeField] private float Xmax = 10f;
    [SerializeField] private float Xmin = -10f;
    [SerializeField] private float Ymax = 5f;
    [SerializeField] private float Ymin = -5f;
    [SerializeField] private float LeaveProbability = 0.1f;
    [SerializeField] private Transform KillZoneTransform;
    [SerializeField] private float CheckOutProbability = 0.1f;
    [SerializeField] private Transform serviceZoneTransform;
    [SerializeField] private float relocationInterval = 5f; // Adjust this value as needed

    private float timer;

    void Start()
    {
        // Initialize the timer
        timer = relocationInterval;
    }

    void Update()
    {
        // Update the timer
        timer -= Time.deltaTime;

        // Check if it's time to relocate
        if (timer <= 0f)
        {
            RelocateDestination();
            // Reset the timer for the next relocation
            timer = relocationInterval;
        }
    }

    private void RelocateDestination()
    {
        float leaveChance = Random.value;
        float CheckOutchance = Random.value;
        if (CheckOutchance <= CheckOutProbability)
        {
            CheckOut();
        }
        else if (leaveChance <= LeaveProbability)
        {
            Leave();

        }
        else
        {
            NewDestinationInShop();
        }
    }

    private void Leave()
    {
        transform.position = new Vector3(9f, -9.5f, transform.position.z);
    }

    private void CheckOut()
    {

    }

    private void NewDestinationInShop()
    {
        float randomX = Random.Range(Xmin, Xmax);
        float randomY = Random.Range(Ymin, Ymax);
        transform.position = new Vector3(randomX, randomY, transform.position.z);
        //Debug.Log("New position selected");
    }
}
