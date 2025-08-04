using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Transform spawnPoint;

    private Transform playerCarTransform;
    private float score;
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
        ScoreUI();
    }

    void ScoreUI()
    {
        score = playerCarTransform.position.z - spawnPoint.position.z;
        score = score * 6;
        scoreText.text = score.ToString("0");
    }
}
