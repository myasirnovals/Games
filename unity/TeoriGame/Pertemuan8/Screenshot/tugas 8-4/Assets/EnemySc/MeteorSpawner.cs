using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] meteor;
    [SerializeField] private float spawnTime;
    private float timer;
    private int i;
    private Camera mainCam;
    private float maxLeft;
    private float maxRight;
    private float yPos;
    public GameObject enemyPrefab;
    public Transform parentTransform;

    void Start()
    {
        Vector3 position = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.identity;
        Instantiate(enemyPrefab);
    }

    void Update()
    {
        
    }
}
