using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteractor : MonoBehaviour
{
    [SerializeField] Transform _interactionPoint;
    [SerializeField] float _interactionPointRadius = 0.5f;
    [SerializeField] LayerMask _interactableMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] int _numFound;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders, _interactableMask);

        if (_numFound > 0 ){
            var interactable = _colliders[0].GetComponent<ObjectInteractable>();

            if (interactable != null && Input.GetKeyDown(KeyCode.F)){
                interactable.Interact(this);
            }
        }
    }

    void OnDrawGizmos(){
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }
}
