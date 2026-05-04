using UnityEngine;
using UnityEngine.UI;
public class MenuSceneManager : MonoBehaviour
{
    
    [SerializeField] private Button Button;

    void Start()
    {
        Button.onClick.AddListener(() => UnityEngine.SceneManagement.SceneManager.LoadScene("_InputSwipe"));
    }

    
    void Update()
    {
        
    }
}
