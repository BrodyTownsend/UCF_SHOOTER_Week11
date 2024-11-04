using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject sideEnemy;
    public GameObject sideSideEnemy;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("CreateSideEnemy", 1f, 6f);
        InvokeRepeating("CreateSideSideEnemy", 3f, 3f);
        Debug.Log("Side Enemy");
        Debug.Log("Side Side Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 8f, 0), Quaternion.identity);
    }

    void CreateSideEnemy()
    {
        Instantiate(sideEnemy, new Vector3(24f, Random.Range(1f, 9f), 0), Quaternion.identity);
        Debug.Log("Side Enemy Spawned");
    }

    void CreateSideSideEnemy()
    {
        Instantiate(sideSideEnemy, new Vector3(-24f, Random.Range(1f, 9f), 0), Quaternion.identity);
        Debug.Log("Side Side Enemy Spawned");
    }
}
