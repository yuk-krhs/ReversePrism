using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 018 SceneLoader                              ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 020 HideAdvScreenAction                      ModelClassType Action Action Action Pointer
    public partial class Model3dLoaderCore : DataModel
    {
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public SceneLoaderAddressable?                  SceneLoader                             { get; set; }
        public Action?                                  HideAdvScreenAction                     { get; set; }

        public static Model3dLoaderCore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Model3dLoaderCore() { Pointer= p0 };

            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x10 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x018), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0x18 SceneLoader                 ( ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.HideAdvScreenAction                       = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 HideAdvScreenAction         ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
