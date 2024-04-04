using UFlow.Core.Runtime;
using UnityEngine;

namespace Blockade.Core.Runtime {
    [CreateAssetMenu(
        fileName = FILE_NAME + nameof(EnvironmentCatalog),
        menuName = MENU_NAME + nameof(EnvironmentCatalog))]
    public class EnvironmentCatalog : BaseContentCatalog<EnvironmentCatalog> {
        [field: SerializeField] public ContentAsset<GameObject> Ground { get; private set; }
    }
}