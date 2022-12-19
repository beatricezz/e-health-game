using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{  public RectTransform fader;
   public void LoadGameScene()
   {  fader.gameObject.SetActive (true);
      LeanTween.alpha (fader, 0,0);
      LeanTween.scale (fader, new Vector3(30,30,1), 0f); 
      LeanTween.alpha (fader, 2,1.5f).setOnComplete(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);});
      
   }
}
