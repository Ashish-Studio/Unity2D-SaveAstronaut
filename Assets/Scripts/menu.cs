using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void One()
    {
        int level01 = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(Example01());
        SceneManager.LoadScene(level01 + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Example01()
    {

        yield return new WaitForSeconds(4);

    }
}
