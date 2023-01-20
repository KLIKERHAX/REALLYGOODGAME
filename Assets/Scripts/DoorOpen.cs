using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Animation>();
    }
    void OnTriggerEnter(Collider collider)
    {
        _animator.SetBool("isopen", true);
    }
    void OnTriggerExit(Collider collider)
    {
        _animator.SetBool("isopen", false);
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
