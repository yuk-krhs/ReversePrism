using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onSucceeded                              Action`1<ISceneLoader> IL2CPP_TYPE_GENERICINST
    // 018 onFailed                                 Action`1<ISceneLoader> IL2CPP_TYPE_GENERICINST
    // 020 onActivated                              Action`1<ISceneLoader> IL2CPP_TYPE_GENERICINST
    // 028 onUnloaded                               Action`1<ISceneLoader> IL2CPP_TYPE_GENERICINST
    // 030 Loader                                   ModelClassType SceneLoaderAsync SceneLoaderAsync SceneLoaderAsync Pointer
    public partial class SceneLoaderAddressable : DataModel
    {
        public SceneLoaderAsync?                        Loader                                  { get; set; }

        public static SceneLoaderAddressable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneLoaderAddressable() { Pointer= p0 };

            value.Loader                                    = GetObject<SceneLoaderAsync>(new IntPtr(p + 0x030), ReversePrism.DataModels.SceneLoaderAsync.FromPointer); // 0x30 Loader                      ( ModelClassType SceneLoaderAsync SceneLoaderAsync SceneLoaderAsync Pointer )

            return value;
        }
    }
}
