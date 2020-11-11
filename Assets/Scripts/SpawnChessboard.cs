using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class SpawnChessboard : MonoBehaviour
{
    public Sprite sprite;

    List<GameObject> tileList = new List<GameObject>();

    bool tilesColorChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Vector3 position = new Vector3();
                position.x = (x * 2) - 4.0f - 0.5f;
                position.y = (y * 2) - 4.0f - 0.5f;
                position.z = 0;

                GameObject spawnedTile = CreateTile();
                spawnedTile.name = (x * 2).ToString() + ", " + (y * 2).ToString();
                spawnedTile.transform.position = position;
                spawnedTile.transform.parent = this.transform;

                tileList.Add(spawnedTile);
            }
        }

        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Vector3 position = new Vector3();
                position.x = (x * 2) - 4.0f - 0.5f + 1.0f;
                position.y = (y * 2) - 4.0f - 0.5f + 1.0f;
                position.z = 0;

                GameObject spawnedTile = CreateTile();
                spawnedTile.name = (x + 1).ToString() + ", " + (y + 1).ToString();
                spawnedTile.transform.position = position;
                spawnedTile.transform.parent = this.transform;

                tileList.Add(spawnedTile);
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!tilesColorChanged)
            {
                for (int i = 0; i < tileList.Count; i++)
                {
                    SpriteRenderer spriteRenderer = tileList[i].GetComponent<SpriteRenderer>();
                    ChangeTileColor(spriteRenderer, new Color(1, 0, 0));
                }

                tilesColorChanged = true;
            }
            else
            {
                for (int i = 0; i < tileList.Count; i++)
                {
                    SpriteRenderer spriteRenderer = tileList[i].GetComponent<SpriteRenderer>();
                    ChangeTileColor(spriteRenderer, new Color(1, 1, 1));
                }

                tilesColorChanged = false;
            }
           
        }
    }

    GameObject CreateTile()
    {
        GameObject tile = new GameObject();

        tile.transform.localScale = new Vector3(2, 2, 2);

        SpriteRenderer spriteRenderer = tile.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
        spriteRenderer.color = new Color(1, 1, 1);

        return tile;
    }

    void ChangeTileColor(SpriteRenderer spriteRenderer, Color color)
    {
        for (int i = 0; i < tileList.Count; i++)
        {
            spriteRenderer.color = color;
        }
    }
}
