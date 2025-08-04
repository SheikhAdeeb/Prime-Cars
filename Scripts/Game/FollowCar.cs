using System.Collections;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    private Transform carTransform;
    private Transform cameraPointTransform;

    private Vector3 velocity = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WaitForPlayer());
    }

    IEnumerator WaitForPlayer()
    {
        GameObject player = null;

        // Wait until the Player is found
        while (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            yield return null; // Wait one frame
        }

        carTransform = player.transform;

        Transform cameraPoint = carTransform.Find("CameraPoint");
        if (cameraPoint != null)
        {
            cameraPointTransform = cameraPoint;
        }
        else
        {
            Debug.LogError("CameraPoint not found as child of Player");
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (carTransform == null || cameraPointTransform == null) return;
        transform.LookAt(carTransform);
        transform.position = Vector3.SmoothDamp(transform.position, cameraPointTransform.position, ref velocity, 5f * Time.deltaTime);
    }
}
