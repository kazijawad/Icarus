using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public void loadScene() {
        SceneManager.LoadScene("foresttest");
    }
}
