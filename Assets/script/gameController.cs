using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    private void Start()
    {
        offset= transform.position - player.transform.position;
    }
    private void LateUpdate()
    {
       transform.position= player.transform.position + offset; 
    }
    public void Reload()
    {
        SceneManager.LoadScene(0);

    }
}
