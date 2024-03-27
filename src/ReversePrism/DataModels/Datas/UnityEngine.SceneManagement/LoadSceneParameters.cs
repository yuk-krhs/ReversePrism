using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LoadSceneMode                          00018659C920 ModelEnumType LoadSceneMode LoadSceneMode LoadSceneMode Int32
    // 014 M_LocalPhysicsMode                       0001865A50E0 ModelEnumType LocalPhysicsMode LocalPhysicsMode LocalPhysicsMode Int32
    public partial class LoadSceneParameters
    {
        public LoadSceneMode                            M_LoadSceneMode                         { get; set; }
        public LocalPhysicsMode                         M_LocalPhysicsMode                      { get; set; }

        public static LoadSceneParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadSceneParameters();

            value.M_LoadSceneMode                           = (LoadSceneMode)GetInt32(new IntPtr(p + 0x010)); // 0270068C5490 0x10 M_LoadSceneMode             ( 00018659C920 ModelEnumType LoadSceneMode LoadSceneMode LoadSceneMode Int32 )
            value.M_LocalPhysicsMode                        = (LocalPhysicsMode)GetInt32(new IntPtr(p + 0x014)); // 0270068C54B0 0x14 M_LocalPhysicsMode          ( 0001865A50E0 ModelEnumType LocalPhysicsMode LocalPhysicsMode LocalPhysicsMode Int32 )

            return value;
        }
    }
}
