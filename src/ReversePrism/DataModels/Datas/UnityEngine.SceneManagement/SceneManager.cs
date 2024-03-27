using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_AllowLoadScene                         bool IL2CPP_TYPE_BOOLEAN
    // 008 sceneLoaded                              UnityAction`2<Scene, LoadSceneMode> IL2CPP_TYPE_GENERICINST
    // 010 sceneUnloaded                            UnityAction`1<Scene> IL2CPP_TYPE_GENERICINST
    // 018 activeSceneChanged                       UnityAction`2<Scene, Scene> IL2CPP_TYPE_GENERICINST
    public partial class SceneManager
    {

        public static SceneManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneManager();


            return value;
        }
    }
}
