using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCube : MonoBehaviour
{
    [SerializeField] private float speed = 90f; // degrés par seconde
    [SerializeField] private InputAction activateRotation =
        new InputAction("ActivateRotation", InputActionType.Button, "<Keyboard>/r");

    private bool rotating = false;

    void Start()
    {
        activateRotation.performed += ToggleRotation;
        activateRotation.Enable();
    }

    void Update()
    {
        if (rotating)
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.Self);
        }
    }

    private void ToggleRotation(InputAction.CallbackContext context)
    {
        rotating = !rotating;
    }
}
