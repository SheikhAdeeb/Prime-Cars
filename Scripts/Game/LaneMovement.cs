using System.Collections;
using UnityEngine;

public class LaneMovement : MonoBehaviour
{
    private Transform playerCarTransform;
    [SerializeField] float offset = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WaitForPlayer());
    }

    IEnumerator WaitForPlayer()
    {
        GameObject player = null;

        while (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            yield return null; // Wait a frame
        }

        playerCarTransform = player.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (playerCarTransform == null) return;
        Vector3 newPos = transform.position;
        newPos.z = playerCarTransform.position.z + offset;
        transform.position = newPos;
    }
}
