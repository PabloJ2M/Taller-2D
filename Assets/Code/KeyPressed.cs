using UnityEngine;
using UnityEngine.InputSystem;

public class KeyPressed : MonoBehaviour
{
    [SerializeField] private InputAction mapa;
    private InputSystem_Actions actionsMap; //null

    private void Awake() => actionsMap = new InputSystem_Actions();
    private void Start() => actionsMap.Player.Interact.performed += OnInteract;
    private void OnEnable() => actionsMap.Enable();
    private void OnDisable() => actionsMap.Disable();

    private void OnInteract(InputAction.CallbackContext ctx)
    {
        print("xD");
    }
}