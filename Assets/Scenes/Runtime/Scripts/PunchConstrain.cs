using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class PunchConstrain : MonoBehaviour, IConstrainController
{

    private TwoBoneIKConstraint constrain;
    private TwoBoneIKConstraint Constrain {get {return constrain == null ? constrain = GetComponent<TwoBoneIKConstraint>() : constrain;}}

    public void AssignTarget(Transform target)
    {
        constrain.data.target=target;
    }

    public void SetWeight(float weight)
    {
        constrain.weight = weight;
    }
}
