using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_From                                   ModelPrimitiveType string string string String
    // 018 M_To                                     ModelPrimitiveType string string string String
    // 020 M_Blend                                  ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32
    public partial class CustomBlend : DataModel
    {
        public string                                   M_From                                  { get; set; }
        public string                                   M_To                                    { get; set; }
        public CinemachineBlendDefinition               M_Blend                                 { get; set; }

        public static CustomBlend? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomBlend() { Pointer= p0 };

            value.M_From                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_From                      ( ModelPrimitiveType string string string String )
            value.M_To                                      = GetString(new IntPtr(p + 0x018)); // 0x18 M_To                        ( ModelPrimitiveType string string string String )
            value.M_Blend                                   = (CinemachineBlendDefinition)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Blend                     ( ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32 )

            return value;
        }
    }
}
