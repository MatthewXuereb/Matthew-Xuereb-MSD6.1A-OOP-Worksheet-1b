using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject gameObject;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBallObject(new Vector3(0.0f, 0.0f, 0.0f));
        SpawnBallObject(new Vector3(1.0f, 0.0f, 0.0f));
        SpawnBallObject(new Vector3(0.0f, 1.0f, 0.0f));
        SpawnBallObject(new Vector3(1.0f, 1.0f, 0.0f));
    }

    void SpawnBallObject(Vector3 worldPos)
    {
        Vector3 position = camera.ViewportToWorldPoint(worldPos);
        position.z = 0;
        Instantiate(gameObject, position, Quaternion.identity);
    }
}
