using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{

    public string nombreAlumno;
    public int año;
    public string orientación;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "" || año < 1 || año > 5)
        {
            Debug.Log("Error: verifique su nombre o año ingresado");
        }
        else
        {
            if (orientación == "T" || orientación == "D" || orientación == "G" || orientación == "M" || orientación == "H")
            {
                if (año < 3)
                {
                    Debug.Log("Error. Aún estás en el ciclo básico");
                }
                else
                {
                    Debug.Log("Muchas gracias " + nombreAlumno + "!");

                }
            }
            else
            {
                Debug.Log("Solo puede ingresar T, D, G, M o H");

            }
        }
       
        

      
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
