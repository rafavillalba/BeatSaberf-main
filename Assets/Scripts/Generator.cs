using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject cube;
    public float spawnTimeMin, spawnTimeMax;

    public void Start()
    {
        StartCoroutine("Spawm");
    }

    public IEnumerator Spawm()
    {
        while (true)
        {
            GameObject CubeRight = null;
            GameObject CubeLeft = null;

            if(Random.Range(0 , 100) < 70)
                CubeRight = Instantiate(cube, transform.position + Vector3.right * 0.2f, Quaternion.identity);
            if(Random.Range(0 , 100) < 70)
                CubeLeft = Instantiate(cube, transform.position + Vector3.right * -0.2f, Quaternion.identity);

            if(CubeRight != null)
                CubeRight.GetComponent<Cube>().angle = Random.Range(0, 4);
            if(CubeLeft != null)    
                CubeLeft.GetComponent<Cube>().angle = Random.Range(0, 4);

            if(Random.Range(0 , 100) < 30 && CubeRight != null) 
            {
                CubeRight.GetComponent<Cube>().blue = false;
            }
            else if(CubeLeft != null)
            {
                if (CubeRight == null)
                    CubeLeft.GetComponent<Cube>().blue = Random.Range(0, 2) == 0? true : false;
                CubeLeft.GetComponent<Cube>().blue = false;
            }
            yield return new WaitForSeconds(Random.Range(spawnTimeMin, spawnTimeMax));
        }
    }
}
