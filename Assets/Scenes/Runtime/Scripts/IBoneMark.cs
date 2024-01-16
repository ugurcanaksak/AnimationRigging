using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBoneMark 
{
    string BoneID {get;}

    void SetBoneWeight(float weight);

    void StartTargetLook();
    void StopTargetLook();
}
