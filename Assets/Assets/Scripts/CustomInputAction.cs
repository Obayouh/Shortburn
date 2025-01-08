using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomInputAction : MonoBehaviour
{
    public InputActionReference customButton;
    public InputActionReference selectButton;

    [SerializeField] private ItemPickedUp[] _items;
    [SerializeField] private ItemPickedUp _currentMovingItem;
    [SerializeField] private GameObject _currentItemGameObject;

    private float _speed = 1.0f;
    //Ray ray;

    private void Start()
    {
        customButton.action.started += ButtonWasPressed;
        customButton.action.canceled += ButtonWasReleased;
        selectButton.action.started += SelectWasPressed;
        selectButton.action.started -= SelectWasReleased;

        _items = FindObjectsOfType<ItemPickedUp>();

        //ray = new Ray(transform.position, transform.forward);

    }

    //void CheckForColliders()
    //{
    //    if (Physics.Raycast(ray, out RaycastHit hit))
    //    {
    //        Debug.Log(hit.collider.gameObject.name + " was hit!");
    //    }
    //}

    private void FixedUpdate()
    {
        for (int i = 0; i < _items.Length; i++)
        {
            if (_items[i]._isMoving == true)
            {
                _currentMovingItem = _items[i];
                _currentItemGameObject = _currentMovingItem.gameObject;
            }
        }
    }

    void ButtonWasPressed(InputAction.CallbackContext context)
    {
        Debug.Log(0);
        var step = _speed * Time.deltaTime;
        _currentItemGameObject.transform.position = Vector3.MoveTowards(_currentItemGameObject.transform.position, this.transform.position, step);
        //CheckForColliders();
    }

    void ButtonWasReleased(InputAction.CallbackContext context)
    {
        Debug.Log(1);
    }

    void SelectWasPressed(InputAction.CallbackContext context)
    {
        Debug.Log(2);
    }
    
    void SelectWasReleased(InputAction.CallbackContext context)
    {
        Debug.Log(3);
    }
}
