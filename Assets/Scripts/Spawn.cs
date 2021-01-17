using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    private float InstantiationTimer = 0f;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;

    void Update()
    {
        CreatePrefab();
        //Debug.Log("Update Paassed");
    }

    public void CreatePrefab()
    {
        Debug.Log("Function Paassed");
        InstantiationTimer += Time.deltaTime;
        if (InstantiationTimer >= 5.0f && InstantiationTimer <= 10f)
        {
            Instantiate(prefab, spawn1.position, Quaternion.identity);
            Instantiate(prefab, spawn2.position, Quaternion.identity);
            InstantiationTimer = 11f;
            Debug.Log("5 has occured!");
        }
        if (InstantiationTimer >= 15.0f && InstantiationTimer <= 20f)
        {
            Instantiate(prefab, spawn3.position, Quaternion.identity);
            Instantiate(prefab, spawn4.position, Quaternion.identity);
            InstantiationTimer = 21f;
        }
        if (InstantiationTimer >= 25.0f && InstantiationTimer <= 30f)
        {
            Instantiate(prefab, spawn5.position, Quaternion.identity);
            Instantiate(prefab, spawn6.position, Quaternion.identity);
            InstantiationTimer = 31f;
        }
    }
}
