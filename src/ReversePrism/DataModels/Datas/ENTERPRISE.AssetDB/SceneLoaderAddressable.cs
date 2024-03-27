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
    // 030 Loader                                   0001866CD290 ModelClassType SceneLoaderAsync SceneLoaderAsync SceneLoaderAsync Pointer
    public partial class SceneLoaderAddressable
    {
        public SceneLoaderAsync?                        Loader                                  { get; set; }

        public static SceneLoaderAddressable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneLoaderAddressable();

            value.Loader                                    = GetObject<SceneLoaderAsync>(new IntPtr(p + 0x030), ReversePrism.DataModels.SceneLoaderAsync.FromPointer); // 027003EF0F48 0x30 Loader                      ( 0001866CD290 ModelClassType SceneLoaderAsync SceneLoaderAsync SceneLoaderAsync Pointer )

            return value;
        }
    }
}
