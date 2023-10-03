using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class YesAndNo : MonoBehaviour
{
    private PlayerActions playerActions;
    private InputAction yesAction;
    private InputAction noAction;
    private int yesCount = 0;
    public int YesCount
    {
        get
        {
            return yesCount;
        }
    }

    public delegate void doYes();
    public doYes DoYes;
    public delegate void doNo();
    public doNo DoNo;

    void Awake()
    {
        playerActions = new PlayerActions();
        yesAction = playerActions.gameplay.yes;
        noAction = playerActions.gameplay.no;
    }

    void OnEnable()
    {
        yesAction.Enable();
        noAction.Enable();
    }

    void OnDisable()
    {
        yesAction.Disable();
        noAction.Disable();
    }

    void Start()
    {
        yesAction.performed += SayYes;
        noAction.performed += SayNo;
    }

    private void SayYes(InputAction.CallbackContext context)
    {
        Debug.Log("Yes!");
        yesCount ++;
        DoYes?.Invoke();

    }

    private void SayNo(InputAction.CallbackContext context)
    {
        Debug.Log("No!");
        DoNo?.Invoke();
    }
}
