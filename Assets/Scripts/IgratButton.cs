using UnityEngine;
using UnityEngine.SceneManagement;
public class IgratButton : MonoBehaviour
{
     public void OnClickPlayButton()
     {
        SceneManager.LoadScene(1);
     }
}
