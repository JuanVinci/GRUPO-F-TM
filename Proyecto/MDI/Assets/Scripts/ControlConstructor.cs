using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControlConstructor : MonoBehaviour
{
    public void CambioEscena()
    {
        SceneManager.LoadScene("Modelos");
    }
}
