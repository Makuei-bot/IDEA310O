using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBottons : MonoBehaviour
{
    public string LevelToLoad = "SampleScene";
  
  public void PlayGame()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
