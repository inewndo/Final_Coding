using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private void Start()
    {
        if(PlayerData.Instance != null)
        {
            transform.position = PlayerData.Instance.savedPosition;
        }
    }
}
