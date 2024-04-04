using Cysharp.Threading.Tasks;
using UFlow.Core.Runtime;
using UnityEngine;

namespace Blockade.Core.Runtime {
    [CreateAssetMenu(
        fileName = FILE_NAME + nameof(GameBootstrap),
        menuName = MENU_NAME + nameof(GameBootstrap))]
    public class GameBootstrap : BaseBootstrap {
        public override async UniTask Boot(IGameContext context) {
            await GameModule.LoadAsync();
        }
    }
}