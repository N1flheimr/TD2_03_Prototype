using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool isConnected;

    public bool isOverlapping;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private bool isGear;

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (PlayerController.instance.useSpaceToConnectAllTiles)
        {
            if (isConnected && TileManager.Instance.canConnect)
            {
                AddConnectedTiles();
            }
        }
        if (PlayerController.instance.useHoldSpaceToConnectTile && TileManager.Instance.connectAll)
        {
            if (isConnected && TileManager.Instance.canConnect)
            {
                AddConnectedTiles();
            }
        }
        spriteRenderer.color = Color.white;

        if (TileManager.Instance.connectedTileList.Contains(gameObject))
        {
            spriteRenderer.color = Color.red;
        }

        if (isOverlapping)
        {
            spriteRenderer.color = Color.blue;
        }

        if (isOverlapping)
        {
            isConnected = false;
        }

        //if (isOverlapping && !isGear)
        //{
        //    BoxCollider2D boxCollider = gameObject.GetComponent<BoxCollider2D>();
        //    boxCollider.enabled = false;
        //}
        //else
        //{
        //    BoxCollider2D boxCollider = gameObject.GetComponent<BoxCollider2D>();
        //    boxCollider.enabled = true;
        //}

    }

    public void AddConnectedTiles()
    {
        TileManager tileManager = TileManager.Instance.GetComponent<TileManager>();
        if (tileManager == null)
        {
            Debug.LogError("error");
        }
        List<GameObject> result = new List<GameObject>();

        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, Vector3.left, tileManager.raycastDistance, LayerMask.GetMask("Tile"));
        if (hit)
        {
            if (!tileManager.connectedTileList.Contains(hit.transform.gameObject))
            {
                result.Add(hit.transform.gameObject);
            }
        }

        hit = Physics2D.Raycast(transform.position, Vector3.right, tileManager.raycastDistance, LayerMask.GetMask("Tile"));
        if (hit)
        {
            if (!tileManager.connectedTileList.Contains(hit.transform.gameObject))
            {
                result.Add(hit.transform.gameObject);
            }
        }

        hit = Physics2D.Raycast(transform.position, Vector3.up, tileManager.raycastDistance, LayerMask.GetMask("Tile"));
        if (hit)
        {
            if (!tileManager.connectedTileList.Contains(hit.transform.gameObject))
            {
                result.Add(hit.transform.gameObject);
            }
        }

        hit = Physics2D.Raycast(transform.position, Vector3.down, tileManager.raycastDistance, LayerMask.GetMask("Tile"));
        if (hit)
        {
            if (!tileManager.connectedTileList.Contains(hit.transform.gameObject))
            {
                result.Add(hit.transform.gameObject);
            }
        }

        foreach (GameObject tileGameObject in result)
        {
            Tile tile = tileGameObject.GetComponent<Tile>();
            tile.isConnected = true;
            tileManager.connectedTileList.Add(tileGameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tile"))
        {
            Tile tile = collision.GetComponent<Tile>();
            tile.isOverlapping = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Tile"))
        {
            Tile tile = collision.GetComponent<Tile>();
            tile.isOverlapping = false;
        }
    }
}
