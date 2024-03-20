using UnityEditor;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(true);
        }
       
    }
}
