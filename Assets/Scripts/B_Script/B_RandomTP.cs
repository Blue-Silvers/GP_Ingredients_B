using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_RandomTP : MonoBehaviour
{
    [Header("Point of teleportation")]
    [SerializeField] private GameObject[] tpSpot;


    [Header("The Exit")]
    [SerializeField] private GameObject exitTp;
    [SerializeField] private bool isExit;

    private void OnTriggerEnter(Collider other)
    {
        if (isExit)
        {
            SceneManager.LoadScene(1);
            //other.gameObject.transform.position = exitTp.transform.position;
        }
        else if(tpSpot.Length > 0)
        {
            int rdTp = Random.Range(0, tpSpot.Length);
            other.gameObject.transform.position = tpSpot[rdTp].transform.position;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
