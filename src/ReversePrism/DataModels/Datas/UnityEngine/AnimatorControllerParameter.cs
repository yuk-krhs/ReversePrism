using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671BA0 ModelPrimitiveType string string string String
    // 018 M_Type                                   0001866B9ED0 ModelEnumType AnimatorControllerParameterType AnimatorControllerParameterType AnimatorControllerParameterType Int32
    // 01C M_DefaultFloat                           000186665900 ModelPrimitiveType float float float Single
    // 020 M_DefaultInt                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 M_DefaultBool                            000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class AnimatorControllerParameter
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
            var value   = new AnimatorControllerParameter();

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 02700226F060 0x10 M_Name                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Type                                    = (AnimatorControllerParameterType)GetInt32(new IntPtr(p + 0x018)); // 02700226F080 0x18 M_Type                      ( 0001866B9ED0 ModelEnumType AnimatorControllerParameterType AnimatorControllerParameterType AnimatorControllerParameterType Int32 )
            value.M_DefaultFloat                            = GetSingle(new IntPtr(p + 0x01C)); // 02700226F0A0 0x1C M_DefaultFloat              ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_DefaultInt                              = GetInt32(new IntPtr(p + 0x020)); // 02700226F0C0 0x20 M_DefaultInt                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_DefaultBool                             = GetBool(new IntPtr(p + 0x024)); // 02700226F0E0 0x24 M_DefaultBool               ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
