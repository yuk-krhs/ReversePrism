using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitID                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 SwitchID                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 TargetNum                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SwitchModelBehaviour
    {
        public int                                      UnitID                                  { get; set; }
        public string                                   SwitchID                                { get; set; }
        public int                                      TargetNum                               { get; set; }

        public static SwitchModelBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchModelBehaviour();

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 027006B650A0 0x10 UnitID                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SwitchID                                  = GetString(new IntPtr(p + 0x018)); // 027006B650C0 0x18 SwitchID                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TargetNum                                 = GetInt32(new IntPtr(p + 0x020)); // 027006B650E0 0x20 TargetNum                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
