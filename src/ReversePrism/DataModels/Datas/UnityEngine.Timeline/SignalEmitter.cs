using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_Retroactive                            ModelPrimitiveType bool bool bool Bool
    // 029 M_EmitOnce                               ModelPrimitiveType bool bool bool Bool
    // 030 M_Asset                                  ModelClassType SignalAsset SignalAsset SignalAsset Pointer
    public partial class SignalEmitter : DataModel
    {
        public bool                                     M_Retroactive                           { get; set; }
        public bool                                     M_EmitOnce                              { get; set; }
        public SignalAsset?                             M_Asset                                 { get; set; }

        public static SignalEmitter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignalEmitter() { Pointer= p0 };

            value.M_Retroactive                             = GetBool(new IntPtr(p + 0x028)); // 0x28 M_Retroactive               ( ModelPrimitiveType bool bool bool Bool )
            value.M_EmitOnce                                = GetBool(new IntPtr(p + 0x029)); // 0x29 M_EmitOnce                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Asset                                   = GetObject<SignalAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.SignalAsset.FromPointer); // 0x30 M_Asset                     ( ModelClassType SignalAsset SignalAsset SignalAsset Pointer )

            return value;
        }
    }
}
