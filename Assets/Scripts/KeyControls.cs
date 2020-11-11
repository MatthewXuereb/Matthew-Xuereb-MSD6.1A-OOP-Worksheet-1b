using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControls : MonoBehaviour
{
    KeyCode downArrow = KeyCode.DownArrow;
    KeyCode upArrow = KeyCode.UpArrow;
    KeyCode leftArrow = KeyCode.LeftArrow;
    KeyCode rightArrow = KeyCode.RightArrow;

    Vector3 position;

    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(downArrow))
        {
            if (camera.ViewportToWorldPoint(position).y >= -50)
            {
                this.transform.SetPositionAndRotation(new Vector3(position.x, position.y - 1, 0), Quaternion.identity);
                position = this.transform.position;
            }
        }
        if (Input.GetKeyDown(upArrow))
        {
            if (camera.ViewportToWorldPoint(position).y <= 40)
            {
                this.transform.SetPositionAndRotation(new Vector3(position.x, position.y + 1, 0), Quaternion.identity);
                position = this.transform.position;
            }
        }
        if (Input.GetKeyDown(leftArrow))
        {
            if (camera.ViewportToWorldPoint(position).x >= -50)
            {
                this.transform.SetPositionAndRotation(new Vector3(position.x - 1, position.y, 0), Quaternion.identity);
                position = this.transform.position;
            }
        }
        if (Input.GetKeyDown(rightArrow))
        {
            if (camera.ViewportToWorldPoint(position).x <= 40)
            {
                this.transform.SetPositionAndRotation(new Vector3(position.x + 1, position.y, 0), Quaternion.identity);
                position = this.transform.position;
            }
        }
    }
}
