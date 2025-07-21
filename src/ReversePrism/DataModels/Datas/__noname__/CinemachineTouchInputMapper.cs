using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TouchSensitivityX                        ModelPrimitiveType float float float Single
    // 024 TouchSensitivityY                        ModelPrimitiveType float float float Single
    // 028 TouchXInputMapTo                         ModelPrimitiveType string string string String
    // 030 TouchYInputMapTo                         ModelPrimitiveType string string string String
    public partial class CinemachineTouchInputMapper : DataModel
    {
        public float                                    TouchSensitivityX                       { get; set; }
        public float                                    TouchSensitivityY                       { get; set; }
        public string                                   TouchXInputMapTo                        { get; set; }
        public string                                   TouchYInputMapTo                        { get; set; }

        public static CinemachineTouchInputMapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineTouchInputMapper() { Pointer= p0 };

            value.TouchSensitivityX                         = GetSingle(new IntPtr(p + 0x020)); // 0x20 TouchSensitivityX           ( ModelPrimitiveType float float float Single )
            value.TouchSensitivityY                         = GetSingle(new IntPtr(p + 0x024)); // 0x24 TouchSensitivityY           ( ModelPrimitiveType float float float Single )
            value.TouchXInputMapTo                          = GetString(new IntPtr(p + 0x028)); // 0x28 TouchXInputMapTo            ( ModelPrimitiveType string string string String )
            value.TouchYInputMapTo                          = GetString(new IntPtr(p + 0x030)); // 0x30 TouchYInputMapTo            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
