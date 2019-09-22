using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelup : MonoBehaviour
{
    int level;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            level = SceneManager.GetActiveScene().buildIndex;
            StartCoroutine(Example());
            SceneManager.LoadScene(level + 1);
        }
    }
    IEnumerator Example()
    {

        yield return new WaitForSeconds(4);

    }
}
