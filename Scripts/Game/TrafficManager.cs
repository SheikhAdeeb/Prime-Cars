using System.Collections;
using UnityEngine;

public class TrafficManager : MonoBehaviour
{
    [SerializeField] Transform[] lanes;
    [SerializeField] GameObject[] trafficVehicles;
    private CarController carController;
    [SerializeField] float minSpawnTime = 30f;
    [SerializeField] float maxSpawnTime = 50f;

    private float dynamicTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WaitForPlayer());
        StartCoroutine(TrafficSpawner());
    }

    IEnumerator WaitForPlayer()
    {
        GameObject player = null;

        while (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            yield return null; // Wait a frame
        }

        carController = player.transform.GetComponent<CarController>();
    }

    IEnumerator TrafficSpawner()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            if (carController.CarSpeed() > 20)
            {
                dynamicTimer = Random.Range(minSpawnTime, maxSpawnTime) / carController.CarSpeed();
                SpawnVehicle();
            }
            yield return new WaitForSeconds(dynamicTimer);
        }
    }

    void SpawnVehicle()
    {
        int randomLane = Random.Range(0, lanes.Length);
        int randomVehicle = Random.Range(0, trafficVehicles.Length);
        Instantiate(trafficVehicles[randomVehicle], lanes[randomLane].position, Quaternion.identity);
    }
}
