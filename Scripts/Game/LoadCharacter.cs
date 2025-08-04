using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
