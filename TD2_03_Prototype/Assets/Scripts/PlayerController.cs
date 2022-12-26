using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [SerializeField] private float moveSpeed = 5f;

    private PlayerMovement controls;

    private Vector3 targetPosition;

    [SerializeField] private bool isOnGearTile = false;

    [SerializeField] private bool isConnectingTiles = false;

    [SerializeField] private Tile currentTile;

    public bool useHoldSpaceToConnectTile;
    public bool useSpaceToConnectAllTiles;

    private void Awake()
    {
        controls = new PlayerMovement();

        targetPosition = transform.position;

        instance = this;
    }

    private void Start()
    {
        controls.Main.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
        if (useSpaceToConnectAllTiles)
        {
            controls.StartAction.RotateTiles.canceled += ctx => StartAction();
        }

        if (useHoldSpaceToConnectTile)
        {
            controls.StartAction.ConnectTiles.performed += ctx => ConnectTiles();
            controls.StartAction.ConnectTiles.canceled += ctx => CheckConnectTiles();
            controls.StartAction.RotateTiles.canceled += ctx => CancelConnectTiles();
            controls.StartAction.ConnectAllTiles.performed += ctx => ConnectAllTiles();
        }
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        if (isConnectingTiles)
        {
            if (!TileManager.Instance.connectedTileList.Contains(currentTile.gameObject))
            {
                TileManager.Instance.connectedTileList.Add(currentTile.gameObject);
            }
        }
    }

    private void ConnectTiles()
    {
        if (isOnGearTile)
        {
            isConnectingTiles = true;
        }
    }

    private void CheckConnectTiles()
    {
        isConnectingTiles = false;

        if (!isOnGearTile || TileManager.Instance.connectedTileList.Count <= 1)
        {
            TileManager.Instance.connectedTileList.Clear();
        }
        else
        {
            StartAction();
        }
    }

    private void CancelConnectTiles()
    {
        if (TileManager.Instance.GetIsDoingAction())
        {
            StartAction();
        }
    }

    private void ConnectAllTiles()
    {
        if (isOnGearTile)
        {
            TileManager.Instance.ConnectAllTiles();
        }
    }

    private void Move(Vector3 direction)
    {
        if (CanMove(direction))
        {
            targetPosition += direction;
        }
    }

    private bool CanMove(Vector3 direction)
    {
        if (!Physics2D.OverlapBox(targetPosition + direction, new Vector2(0.5f, 0.5f), LayerMask.GetMask("Tile")) || TileManager.Instance.GetIsDoingAction())
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void StartAction()
    {
        if (isOnGearTile)
        {
            TileManager.Instance.StartAction();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tile"))
        {
            currentTile = collision.transform.GetComponent<Tile>();
            TileManager.Instance.pivotTileTransform = currentTile.transform;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Gear"))
        {
            isOnGearTile = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Gear"))
        {
            isOnGearTile = false;
        }
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
