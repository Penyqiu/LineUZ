using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void ManageScene(int level)
    {
          SceneManager.LoadScene(level);
    }
  }  
