using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject uiObj;
    // Start is called before the first frame update
    void Start()
    {
        uiObj.SetActive(false);
    }

    private void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player") 
        {
            uiObj.SetActive(true);
            StartCoroutine("Wait"); // pause execution for another process to run 
        }
    }

    IEnumerator Wait() // interface, allows "Goal!!" to be displayed for 3 seconds
    {
        yield return new WaitForSeconds(3); // create a timer thread
        Destroy(uiObj);
        Destroy(gameObject);
    }
}
