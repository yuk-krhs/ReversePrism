using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CostumeId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 IconPath                                 000186672F10 ModelPrimitiveType string string string String
    // 020 IsOnSet                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 021 IsDefault                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class CostumeCellData : DataModel
    {
        public int                                      CostumeId                               { get; set; }
        public string                                   IconPath                                { get; set; }
        public bool                                     IsOnSet                                 { get; set; }
        public bool                                     IsDefault                               { get; set; }

        public static CostumeCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeCellData() { Pointer= p0 };

            value.CostumeId                                 = GetInt32(new IntPtr(p + 0x010)); // 02466629D8C0 0x10 CostumeId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IconPath                                  = GetString(new IntPtr(p + 0x018)); // 02466629D8E0 0x18 IconPath                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsOnSet                                   = GetBool(new IntPtr(p + 0x020)); // 02466629D900 0x20 IsOnSet                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x021)); // 02466629D920 0x21 IsDefault                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
