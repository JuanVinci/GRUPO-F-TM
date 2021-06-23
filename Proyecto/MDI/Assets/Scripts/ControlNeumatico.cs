using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNeumatico : MonoBehaviour
{
    public void CambioEscena()
    {
        SceneManager.LoadScene("CambioNeumatico");
    }
}
