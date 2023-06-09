using UnityEngine;
using WebXR;
using Zinnia.Action;

public class ControllerButtonAction : BooleanAction
{
    [SerializeField]
    private WebXRController controller;
    [SerializeField]
    private WebXRController.ButtonTypes buttonType;

    // Update is called once per frame
    void Update()
    {
        Receive(controller.GetButton(buttonType));
    }
}
