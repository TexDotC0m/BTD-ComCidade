using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTrash : MonoBehaviour
{

    public GameObject[] lixos;
    public GameObject[] lixos1;
    int rdm;
    int rdm1;
  

    public void Start()
    {
        rdm = Random.Range(0, 5);
        rdm1 = Random.Range(0, 5);

        lixos[rdm].SetActive(true);
        lixos[rdm1].SetActive(true);

       
    }

}
