using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateScript : MonoBehaviour
{
    [SerializeField]
    private GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeActiveState()
    {
        sphere.SetActive(!sphere.activeSelf);
    }
}
