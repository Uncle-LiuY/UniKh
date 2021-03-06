
using System.Collections;
using UniKh.res;
using UnityEngine;

namespace UniKh.comp {
    
    public class DelayDestroy : DelayBase<DelayActivate>  {

        [Header("Target GameObject (or self)")]
        public GameObject target;
        //
        // [Header("tid of using ResPool or 0")]
        // public uint tid;
        //
        public override IEnumerator DoDelayEvent() {
            if (triggerOn == TriggerOn.OnInit) {
                Debug.LogError("TriggerOn flag of DelayDestroy object should not be set to OnInit.");
                triggerOn = TriggerOn.OnActive;
            }

            ResPool.LazyInst.Kill(gameObject);
            
            // if (tid > 0 && ResPool.LazyInst.TidExist(tid)) {
            //     ResPool.LazyInst.Kill(target ? target : gameObject);
            // } else {
            //     Destroy(target ? target : gameObject);
            // }
            
            yield break; 
        }
    }
}