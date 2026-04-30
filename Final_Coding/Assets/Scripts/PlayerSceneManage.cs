using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneManage : MonoBehaviour
{
    private Vector3 targetPos;
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            targetPos = transform.position;
            SceneManager.sceneLoaded += OnSceneLoaded;
            string nextScene = SceneManager.GetActiveScene().name == "Past_Game"
                ? "Present_Game"
                : "Past_Game";
            SceneManager.LoadScene(nextScene);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        transform.position = targetPos;
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
