using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ForwardTo                              ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 018 M_Util                                   ModelClassType IUtil IUtil IUtil Pointer
    // 020 UseTransactionLog                        ModelPrimitiveType bool bool bool Bool
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

            value.M_ForwardTo                               = GetObject<IStoreCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreCallback.FromPointer); // 0x10 M_ForwardTo                 ( ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x018), ReversePrism.DataModels.IUtil.FromPointer); // 0x18 M_Util                      ( ModelClassType IUtil IUtil IUtil Pointer )
            value.UseTransactionLog                         = GetBool(new IntPtr(p + 0x020)); // 0x20 UseTransactionLog           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
