using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RighthandBone : MonoBehaviour, IBoneMark
{
    public string BoneID => "RightHand";
    
    [SerializeField]
    private float searchRadius;
    private bool isLookingForTarget;

     [SerializeField]
     private GameObject Constrain;

     private IConstrainController constrainController;
     private IConstrainController ConstrainController {get {return constrainController == null ? constrainController = Constrain.GetComponent<IConstrainController>() : constrainController;}}


    public void SetBoneWeight(float weight)
    {
        ConstrainController.SetWeight(weight);
    }

    private void Update()
    {
        if (!isLookingForTarget) return;
        searchForTarget();
    }

    public void StartTargetLook()
    {
        isLookingForTarget=true;
    }

    public void StopTargetLook()
    {
        isLookingForTarget=false;
    }

    private void searchForTarget()
    {
         RaycastHit[] hits = Physics.SphereCastAll(transform.position, searchRadius, transform.forward, 1f);
            Debug.Log($"Targets: {hits.Length}");
            foreach (var hit in hits)
            {
                var target = hit.collider.GetComponent<IAnimatonTarget>();
                if (target != null)
                {
                    Debug.Log($"target found: {hit.collider.name}");
                    ConstrainController.AssignTarget(target.t);
                }
            }
    }
}
