using Flecs.NET.Core;
using UFlow.Addon.Flecs.Core.Runtime;
using UFlow.Core.Runtime;
using UnityEngine;

namespace Blockade.Core.Runtime {
    public sealed class MoveToCursorSystem : BaseSystem {
        private Query m_cameraQuery;
        
        protected override Routine BuildRoutine() {
            m_cameraQuery = World.Query<GameCameraCmp>();
            return World
                .Routine<Transform, MoveToCursorCmp>()
                .Kind<PostRender>()
                .Each((ref Transform transform) => {
                    var camEntity = m_cameraQuery.Find((ref GameCameraCmp c) => true);
                    if (!camEntity.IsAlive()) return;
                    transform.position = camEntity.Get<GameCameraCmp>().Cam.ScreenToWorldPoint(Input.mousePosition)._xy0();
                });
        }
    }
}