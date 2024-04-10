using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ForwardTo                              000186659160 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 018 M_Util                                   0001866905E0 ModelClassType IUtil IUtil IUtil Pointer
    // 020 UseTransactionLog                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ScriptingStoreCallback : DataModel
    {
        public IStoreCallback?                          M_ForwardTo                             { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }
        public bool                                     UseTransactionLog                       { get; set; }

        public static ScriptingStoreCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptingStoreCallback() { Pointer= p0 };

            value.M_ForwardTo                               = GetObject<IStoreCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0245A68D2768 0x10 M_ForwardTo                 ( 000186659160 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x018), ReversePrism.DataModels.IUtil.FromPointer); // 0245A68D2788 0x18 M_Util                      ( 0001866905E0 ModelClassType IUtil IUtil IUtil Pointer )
            value.UseTransactionLog                         = GetBool(new IntPtr(p + 0x020)); // 0245A68D27A8 0x20 UseTransactionLog           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
