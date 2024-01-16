using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnimationEventListener : MonoBehaviour
{
    private List<IBoneMark> boneMarks;
    private List<IBoneMark> BoneMarks {get {return boneMarks == null ? boneMarks = new List<IBoneMark>(GetComponentsInChildren<IBoneMark>()) : boneMarks; }}

    public void SetWeight(AnimationEvent animationEvent)
    {
        BoneMarks.Where(b => string.Equals(b.BoneID, animationEvent.stringParameter)).FirstOrDefault().SetBoneWeight(animationEvent.floatParameter);
    }
    public void StartTargetCheck(string id)
    {
         BoneMarks.Where(b => string.Equals(b.BoneID, id)).FirstOrDefault().StartTargetLook();
    }

    public void StopTargetCheck(string id)
    {
         BoneMarks.Where(b => string.Equals(b.BoneID, id)).FirstOrDefault().StopTargetLook();
    }
}
