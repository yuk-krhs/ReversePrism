using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CostumeId                                ModelPrimitiveType int int int Int32
    // 018 IconPath                                 ModelPrimitiveType string string string String
    // 020 IsOnSet                                  ModelPrimitiveType bool bool bool Bool
    // 021 IsDefault                                ModelPrimitiveType bool bool bool Bool
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

            value.CostumeId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 CostumeId                   ( ModelPrimitiveType int int int Int32 )
            value.IconPath                                  = GetString(new IntPtr(p + 0x018)); // 0x18 IconPath                    ( ModelPrimitiveType string string string String )
            value.IsOnSet                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsOnSet                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x021)); // 0x21 IsDefault                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
