using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileManager : MonoBehaviour
{
    public static TileManager Instance { get; private set; }

    public List<GameObject> tileList = new List<GameObject>();
    public List<GameObject> connectedTileList = new List<GameObject>();

    [SerializeField] private bool isDoingAction = false;

    public Transform pivotTileTransform;

    [SerializeField] private Tile currentPivotTile;

    public bool canConnect = true;
    public bool connectAll = false;

    public float raycastDistance;
    private float connectTimer;

    [SerializeField] private float waitTime;

    private void Awake()
    {
        connectTimer = waitTime;
    }

    private void Start()
    {
        Instance = this;

        GameObject[] tileArray = GameObject.FindGameObjectsWithTag("Tile");

        foreach (GameObject tile in tileArray)
        {
            tileList.Add(tile);
        }
    }

    private void Update()
    {
        if (isDoingAction && canConnect)
        {
            connectTimer -= Time.deltaTime;
        }

        if (connectTimer < 0)
        {
            canConnect = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && isDoingAction)
        {
            foreach (GameObject tile in connectedTileList)
            {
                tile.transform.RotateAround(pivotTileTransform.position, Vector3.forward, 90f);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && isDoingAction)
        {
            foreach (GameObject tile in connectedTileList)
            {
                tile.transform.RotateAround(pivotTileTransform.position, Vector3.forward, -90f);
            }
        }
    }

    public void StartAction()
    {
        if (!isDoingAction)
        {
            connectTimer = waitTime;
            if (PlayerController.instance.useSpaceToConnectAllTiles)
            {
                CheckConnectedTile();
            }
            isDoingAction = !isDoingAction;
        }
        else
        {
            if (PlayerController.instance.useSpaceToConnectAllTiles)
            {
                foreach (GameObject tileGameObject in connectedTileList)
                {
                    Tile tile = tileGameObject.GetComponent<Tile>();
                    tile.isConnected = false;
                }
            }

            connectTimer = waitTime;
            ClearConnectedTiles();
            canConnect = true;
            currentPivotTile = null;
            isDoingAction = !isDoingAction;
        }
    }

    public void ConnectAllTiles()
    {
        if (!isDoingAction)
        {
            connectTimer = waitTime;
            CheckConnectedTile();
            isDoingAction = !isDoingAction;
            connectAll = true;
        }
        else
        {
            if (PlayerController.instance.useSpaceToConnectAllTiles)
            {
                foreach (GameObject tileGameObject in connectedTileList)
                {
                    Tile tile = tileGameObject.GetComponent<Tile>();
                    tile.isConnected = false;
                }
            }

            connectTimer = waitTime;
            ClearConnectedTiles();
            canConnect = true;
            currentPivotTile = null;
            isDoingAction = !isDoingAction;
            connectAll = false;
        }
    }

    public bool GetIsDoingAction()
    {
        return isDoingAction;
    }

    public void CheckConnectedTile()
    {
        ClearConnectedTiles();

        currentPivotTile = pivotTileTransform.GetComponent<Tile>();

        currentPivotTile.AddConnectedTiles();
        connectedTileList.Add(currentPivotTile.gameObject);
    }

    public void ClearConnectedTiles()
    {
        connectedTileList.Clear();
    }
}
