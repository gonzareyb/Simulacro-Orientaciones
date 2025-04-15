using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
{
    public string nombreAlumno;
    public float añoAlumno;
    public string orientacionAlumno;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("Error");
            return;
        }

        if (añoAlumno < 1 && añoAlumno > 5)
        {
            Debug.Log("Año incorrecto");
            return;
        }

        if (añoAlumno == 1 || añoAlumno == 2)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }

        if (orientacionAlumno == "T" || orientacionAlumno == "D" || orientacionAlumno == "G" || orientacionAlumno == "H" || orientacionAlumno == "M")
        {
            Debug.Log("Muchas Gracias " + nombreAlumno + "!"); 
        }

        else
        {
           
            Debug.Log("Orientacion incorrecta");
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
