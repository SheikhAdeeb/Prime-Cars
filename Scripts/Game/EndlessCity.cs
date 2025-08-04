using System.Collections;
using UnityEngine;

public class EndlessCity : MonoBehaviour
{
    private Transform playerCarTransform;
    [SerializeField] Transform otherCityTransform;
    [SerializeField] float halfLength;
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
    void Update()
    {
        if (playerCarTransform == null) return;
        if (playerCarTransform.position.z > transform.position.z + halfLength + 10f)
        {
            transform.position = new Vector3(0, 0, otherCityTransform.position.z + halfLength * 2);
        }
    }
}
