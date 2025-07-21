using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BlendHint                              ModelEnumType BlendHint BlendHint BlendHint Int32
    // 014 M_InheritPosition                        ModelPrimitiveType bool bool bool Bool
    // 018 M_OnCameraLive                           ModelClassType VcamActivatedEvent VcamActivatedEvent VcamActivatedEvent Pointer
    public partial class TransitionParams : DataModel
    {
        public BlendHint                                M_BlendHint                             { get; set; }
        public bool                                     M_InheritPosition                       { get; set; }
        public VcamActivatedEvent?                      M_OnCameraLive                          { get; set; }

        public static TransitionParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransitionParams() { Pointer= p0 };

            value.M_BlendHint                               = (BlendHint)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_BlendHint                 ( ModelEnumType BlendHint BlendHint BlendHint Int32 )
            value.M_InheritPosition                         = GetBool(new IntPtr(p + 0x014)); // 0x14 M_InheritPosition           ( ModelPrimitiveType bool bool bool Bool )
            value.M_OnCameraLive                            = GetObject<VcamActivatedEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.VcamActivatedEvent.FromPointer); // 0x18 M_OnCameraLive              ( ModelClassType VcamActivatedEvent VcamActivatedEvent VcamActivatedEvent Pointer )

            return value;
        }
    }
}
