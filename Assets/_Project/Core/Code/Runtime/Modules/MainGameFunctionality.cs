using Flecs.NET.Core;
using UFlow.Addon.Flecs.Core.Runtime;

namespace Blockade.Core.Runtime {
    public class MainGameFunctionality : IFlecsModule {
        public void InitModule(ref World world) {
            world.Module<MainGameFunctionality>();
            world.AddSystem<AimAtTargetSystem>();
            world.AddSystem<MoveToCursorSystem>();
        }
    }
}