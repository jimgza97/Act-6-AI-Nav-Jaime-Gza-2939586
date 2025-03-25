using UnityEngine;
using UnityEngine.AI;

[RequireComponent  (typeof(NavMeshAgent))]
public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] LayerMask groundMask;

    InputSystem_Actions input;

    NavMeshAgent agent;

    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }
    private void Awake()
    {
        input = new();
    }
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        input.Player.Click.performed += ct =>
        {
            Ray ray = Camera.main.ScreenPointToRay(input.Player.Point.ReadValue<Vector2>());
           if(Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, groundMask))
           {
                agent.destination = hit.point;
           }
        };
    }
}
