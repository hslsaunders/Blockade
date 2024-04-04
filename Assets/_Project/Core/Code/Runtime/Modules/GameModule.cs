using Cysharp.Threading.Tasks;
using Flecs.NET.Core;
using UFlow.Addon.Flecs.Core.Runtime;
using UFlow.Core.Runtime;

namespace Blockade.Core.Runtime {
    public class GameModule : BaseSceneModule<GameModule> {
        public override string SceneName => "GameScene";
        
        public World World { get; private set; }

        protected override UniTask PostSceneLoadAsync() {
            World = UFlowAPI.Modules.Load(new EcsModule<GameModule>(true, true, true)).World;
            World.SetCurrent();
            World.Import<MainGameFunctionality>();

            CommonCatalog.Get().GameCamera.InstantiateImmediate();
            EnvironmentCatalog.Get().Ground.InstantiateImmediate();
            
            return base.PostSceneLoadAsync();
        }

        protected override UniTask PostSceneUnloadAsync() {
            EcsModule<GameModule>.Unload();
            return base.PostSceneUnloadAsync();
        }
    }
}