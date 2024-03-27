using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_cache                                  GotoInstruction[] IL2CPP_TYPE_SZARRAY
    // 018 HasResult                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 019 HasValue                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 01A LabelTargetGetsValue                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class GotoInstruction
    {
        public bool                                     HasResult                               { get; set; }
        public bool                                     HasValue                                { get; set; }
        public bool                                     LabelTargetGetsValue                    { get; set; }

        public static GotoInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GotoInstruction();

            value.HasResult                                 = GetBool(new IntPtr(p + 0x018)); // 0270D9FA41B8 0x18 HasResult                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.HasValue                                  = GetBool(new IntPtr(p + 0x019)); // 0270D9FA41D8 0x19 HasValue                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.LabelTargetGetsValue                      = GetBool(new IntPtr(p + 0x01A)); // 0270D9FA41F8 0x1A LabelTargetGetsValue        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
