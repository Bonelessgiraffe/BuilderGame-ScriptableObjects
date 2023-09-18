using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuidingManager : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private Transform woodHarvester;
    
    private void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(woodHarvester, GetMouseWorldPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 MouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        MouseWorldPosition.z = 0f;
        return MouseWorldPosition;
    }
}
