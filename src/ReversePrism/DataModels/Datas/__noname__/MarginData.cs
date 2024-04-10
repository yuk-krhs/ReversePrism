using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DeviceName                               0001866722E0 ModelPrimitiveType string string string String
    // 018 ModelName                                0001866722E0 ModelPrimitiveType string string string String
    // 020 Left                                     000186666050 ModelPrimitiveType float float float Single
    // 024 Right                                    000186666050 ModelPrimitiveType float float float Single
    // 028 Top                                      000186666050 ModelPrimitiveType float float float Single
    // 02C Bottom                                   000186666050 ModelPrimitiveType float float float Single
    public partial class MarginData : DataModel
    {
        public string                                   DeviceName                              { get; set; }
        public string                                   ModelName                               { get; set; }
        public float                                    Left                                    { get; set; }
        public float                                    Right                                   { get; set; }
        public float                                    Top                                     { get; set; }
        public float                                    Bottom                                  { get; set; }

        public static MarginData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarginData() { Pointer= p0 };

            value.DeviceName                                = GetString(new IntPtr(p + 0x010)); // 0245A448FBA8 0x10 DeviceName                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ModelName                                 = GetString(new IntPtr(p + 0x018)); // 0245A448FBC8 0x18 ModelName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Left                                      = GetSingle(new IntPtr(p + 0x020)); // 0245A448FBE8 0x20 Left                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Right                                     = GetSingle(new IntPtr(p + 0x024)); // 0245A448FC08 0x24 Right                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Top                                       = GetSingle(new IntPtr(p + 0x028)); // 0245A448FC28 0x28 Top                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Bottom                                    = GetSingle(new IntPtr(p + 0x02C)); // 0245A448FC48 0x2C Bottom                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
