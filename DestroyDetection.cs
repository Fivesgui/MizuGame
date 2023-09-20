using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyDetection : MonoBehaviour
    {

       private static int objectsNeedToBeDestroyed = 0; 
       private static int objectsDestroyed = 0;
       
       void Start()
       {
          ++objectsNeedToBeDestroyed;
       }

       void OnDestroy() //will be called on destroying the object
       {
          if(++objectsDestroyed == objectsNeedToBeDestroyed)
          {
            SceneManager.LoadScene("Menu Principal");
          }
       }
    }
