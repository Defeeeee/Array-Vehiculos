using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] vehiculos;


    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()     
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            DeactivateAll();
            vehiculos[Random.Range(0, vehiculos.Length)].SetActive(true);
        }   
    }

    void ResetearVehiculos()
    {
        DeactivateAll();
        vehiculos[0].SetActive(true);
    }

    void DeactivateAll()
    {
        /* foreach (var vehiculo in vehiculos)
            {
                vehiculo.SetActive(false);
            }
        */
        
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
    
    void ActivateAll()
    {
        /* foreach (var vehiculo in vehiculos)
            {
                vehiculo.SetActive(false);
            }
        */
        
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(true);
        }
    }
}
