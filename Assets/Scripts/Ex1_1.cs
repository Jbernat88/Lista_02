using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1_1 : MonoBehaviour
{
    public GameObject prefabSphere;
    [SerializeField] private int sphereNumber = 1;
    [SerializeField] private int waveNumber = 1;

    //Camera Limits
    private int rangeX = 7;
    private int rangeY = 5;
    private int rangeZ = 5;



    private void Update()
    {
        //When you finish off the enemies it gives way to a new round
        if (waveNumber== 0) 
        {
            GenerateSphere(waveNumber);
        }
    }

    public void GenerateSphere(int spheresToGenerate)
    {
        //Add a round.
        waveNumber++;

        //instance the same number of enemies as number of round we find.   
        for (int i = 0; i < waveNumber; i++) 
        {
            Vector3 randomPosition = new Vector3(Random.Range(rangeX, -rangeX), Random.Range(rangeY, -rangeY), Random.Range(rangeZ, 0));
            GameObject obj = Instantiate(prefabSphere);
            obj.transform.position = randomPosition;

            sphereNumber = waveNumber;
        }

    }

    //Remove a number of enemys.
    public void AddPoint()
    {
        sphereNumber--;
    }
}
