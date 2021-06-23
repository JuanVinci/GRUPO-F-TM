using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSpecs : MonoBehaviour
{
    public void CambioEscena()
    {
        SceneManager.LoadScene("Especificaciones");
    }
}
