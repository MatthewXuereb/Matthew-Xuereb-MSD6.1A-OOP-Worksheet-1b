using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class DragBallAlongMouse : MonoBehaviour
{
    public GameObject gameObject;
    public Camera camera;

    GameObject spawn;

    Vector3 position;

    private void Awake()
    {
        position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;

        spawn = Instantiate(gameObject, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;

        spawn.transform.position = position;
    }
}
