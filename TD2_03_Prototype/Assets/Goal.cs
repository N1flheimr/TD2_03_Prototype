using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private float sceneLoadTime;
    Tile tile;

    private void Awake()
    {
        tile =  GetComponent<Tile>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!tile.isOverlapping)
            {
                StartCoroutine(GoToNextScene(sceneName));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopCoroutine(GoToNextScene(sceneName));
    }

    private IEnumerator GoToNextScene(string sceneName)
    {
        yield return new WaitForSeconds(sceneLoadTime);
        SceneManager.LoadScene(sceneName);
    }
}
