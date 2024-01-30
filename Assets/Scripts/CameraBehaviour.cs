using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject followObject;
    private Vector3 _followedPos = new Vector3();
    
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        _followedPos = followObject.transform.position;
        transform.position = new Vector3(_followedPos.x, 5, _followedPos.z-15);
    }
}
