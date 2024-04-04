using UnityEngine;

namespace Blockade.Core.Runtime {
    public struct GameCameraCmp {
        [field: SerializeField] public Camera Cam { get; private set; }
    }
}