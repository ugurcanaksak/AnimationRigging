using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConstrainController 
{
    void SetWeight(float weight);

    void AssignTarget(Transform target);
}
