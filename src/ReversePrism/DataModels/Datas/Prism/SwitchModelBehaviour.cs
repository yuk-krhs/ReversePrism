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
    public partial class SwitchModelBehaviour : DataModel
    {
        public int                                      UnitID                                  { get; set; }
        public string                                   SwitchID                                { get; set; }
        public int                                      TargetNum                               { get; set; }

        public static SwitchModelBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchModelBehaviour() { Pointer= p0 };

            value.UnitID                                    = GetInt32(new IntPtr(p + 0x010)); // 024664E72C98 0x10 UnitID                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SwitchID                                  = GetString(new IntPtr(p + 0x018)); // 024664E72CB8 0x18 SwitchID                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TargetNum                                 = GetInt32(new IntPtr(p + 0x020)); // 024664E72CD8 0x20 TargetNum                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
