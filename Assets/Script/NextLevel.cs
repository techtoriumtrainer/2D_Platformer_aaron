using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Level 2");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
