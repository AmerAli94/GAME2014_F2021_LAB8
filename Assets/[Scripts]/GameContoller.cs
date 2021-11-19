using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContoller : MonoBehaviour
{
    public Transform player;
    public Transform playerSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        player.position = playerSpawnPoint.position;
    }
    
}
