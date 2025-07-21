using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Type                                   ModelEnumType AnimatorControllerParameterType AnimatorControllerParameterType AnimatorControllerParameterType Int32
    // 01C M_DefaultFloat                           ModelPrimitiveType float float float Single
    // 020 M_DefaultInt                             ModelPrimitiveType int int int Int32
    // 024 M_DefaultBool                            ModelPrimitiveType bool bool bool Bool
    public partial class AnimatorControllerParameter : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public AnimatorControllerParameterType          M_Type                                  { get; set; }
        public float                                    M_DefaultFloat                          { get; set; }
        public int                                      M_DefaultInt                            { get; set; }
        public bool                                     M_DefaultBool                           { get; set; }

        public static AnimatorControllerParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatorControllerParameter() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Type                                    = (AnimatorControllerParameterType)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Type                      ( ModelEnumType AnimatorControllerParameterType AnimatorControllerParameterType AnimatorControllerParameterType Int32 )
            value.M_DefaultFloat                            = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_DefaultFloat              ( ModelPrimitiveType float float float Single )
            value.M_DefaultInt                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_DefaultInt                ( ModelPrimitiveType int int int Int32 )
            value.M_DefaultBool                             = GetBool(new IntPtr(p + 0x024)); // 0x24 M_DefaultBool               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
