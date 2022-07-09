using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorControlesBuild : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject FreeCamera;
    [SerializeField] private GameObject VR;

    void Start()
    {
    #if UNITY_EDITOR_WIN
        FreeCamera.SetActive(true);
        VR.SetActive(false);
        #endif
    #if UNITY_ANDROID
        FreeCamera.SetActive(false);
        VR.SetActive(true);
    #endif
    #if UNITY_STANDALONE_WIN
        FreeCamera.SetActive(true);
        VR.SetActive(false);
    #endif
    }

    // Update is called once per frame
    void Update()
    {
    }
}
