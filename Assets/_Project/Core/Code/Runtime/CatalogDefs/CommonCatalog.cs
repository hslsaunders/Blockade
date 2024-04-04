using UFlow.Core.Runtime;
using UnityEngine;

namespace Blockade.Core.Runtime {
    [CreateAssetMenu(
        fileName = FILE_NAME + nameof(CommonCatalog),
        menuName = MENU_NAME + nameof(CommonCatalog))]
    public class CommonCatalog : BaseContentCatalog<CommonCatalog> {
        [field: SerializeField] public ContentAsset<GameObject> GameCamera { get; private set; }
    }
}