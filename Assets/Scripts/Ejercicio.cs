using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{

    public string nombreAlumno;
    public int año;
    public char orientación;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "" || año < 1 || año > 5)
        {
            Debug.Log("Error");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
