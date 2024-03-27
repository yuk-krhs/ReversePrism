using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 000 _sceneLoader                             SceneLoaderAddressable IL2CPP_TYPE_CLASS
    // 008 isContinueBGM                            bool IL2CPP_TYPE_BOOLEAN
    public partial class Model3DManager
    {
        public ScenarioManager?                         ScenarioManager                         { get; set; }

        public static Model3DManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Model3DManager();

            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScenarioManager.FromPointer); // 027006100BC0 0x20 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
