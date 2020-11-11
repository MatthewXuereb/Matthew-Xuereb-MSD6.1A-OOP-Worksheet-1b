using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnClick : MonoBehaviour
{
    public GameObject gameObject;
    public Camera camera;

    int currentSpawnCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentSpawnCount < 5)
            {
                Vector3 position = camera.ScreenToWorldPoint(Input.mousePosition);
                position.z = 0;
                Instantiate(gameObject, position, Quaternion.identity);

                currentSpawnCount++;
            }
        }
    }
}
