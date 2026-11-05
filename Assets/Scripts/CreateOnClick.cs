using UnityEngine;
using UnityEngine.InputSystem;

public class CreateOnClick : MonoBehaviour
{
    [SerializeField] private Rigidbody projectilePrefab;
    [SerializeField] private InputAction fire =
        new InputAction("Fire", InputActionType.Button, "<Mouse>/rightButton");

    void Start()
    {
        fire.Enable();
    }

    void Update()
    {
        if (fire.WasPressedThisFrame())
        {
            Vector3 position = transform.position + transform.forward * 2f;
            Rigidbody projectile = Instantiate(projectilePrefab, position, transform.rotation);
            projectile.AddForce(transform.forward * 12f, ForceMode.Impulse);
            Destroy(projectile.gameObject, 8f);
        }
    }
}
