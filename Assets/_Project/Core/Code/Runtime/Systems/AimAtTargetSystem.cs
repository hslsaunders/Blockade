using Flecs.NET.Core;
using UFlow.Addon.Flecs.Core.Runtime;
using UnityEngine;

namespace Blockade.Core.Runtime {
    public sealed class AimAtTargetSystem : BaseSystem {
        protected override Routine BuildRoutine() {
            return World
                .Routine<Transform, AimAtTargetCmp>()
                .Kind<PostRender>()
                .Each((Entity e, ref Transform transform, ref AimAtTargetCmp aimAtTargetCmp) => {
                    GameObject targetObj;
                    //if ((targetObj = e.GetSecond<AimAtTargetCmp, GameObject>()) == null) return;
                    targetObj = aimAtTargetCmp.target;
                    if (targetObj != null)
                        transform.transform.right = (targetObj.transform.position - transform.position).normalized;
                });
        }
    }
}