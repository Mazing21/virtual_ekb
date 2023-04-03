using UnityEngine;
using UnityEngine.SceneManagement;
public class button : MonoBehaviour
{
    public void OnClick(int i)
    {
        SceneManager.LoadScene(i);
    }

}
