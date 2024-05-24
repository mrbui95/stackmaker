using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject map;

    [Header("Maps Component")] 
    [SerializeField] public GameObject brickPrefab;
    [SerializeField] public GameObject pivotePrefab;
    [SerializeField] public GameObject unPivotePrefab;
    [SerializeField] public GameObject startPrefab;
    [SerializeField] public GameObject finishPrefab;

    private int currentLevel = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateMap(int level)
    {
        if (currentLevel != level)
        {
            ResetMap();
        }

        string fileLevel = "";
    }

    private void ResetMap()
    {

    }
}
