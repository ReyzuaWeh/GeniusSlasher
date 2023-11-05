using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene(0); //balik ke menu
    }
}
