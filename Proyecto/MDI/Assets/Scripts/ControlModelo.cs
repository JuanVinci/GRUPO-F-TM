using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControlModelo : MonoBehaviour
{
    public void CambioEscena()
    {
        SceneManager.LoadScene("Eleccion");
    }
}
