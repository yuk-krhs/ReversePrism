using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TitleName                                0001866722E0 ModelPrimitiveType string string string String
    // 018 AssetKey                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 UnitId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 IsForceAddList                           000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class HowToPlayProduceManual : DataModel
    {
        public string                                   TitleName                               { get; set; }
        public string                                   AssetKey                                { get; set; }
        public int                                      UnitId                                  { get; set; }
        public bool                                     IsForceAddList                          { get; set; }

        public static HowToPlayProduceManual? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayProduceManual() { Pointer= p0 };

            value.TitleName                                 = GetString(new IntPtr(p + 0x010)); // 024665CF15E8 0x10 TitleName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AssetKey                                  = GetString(new IntPtr(p + 0x018)); // 024665CF1608 0x18 AssetKey                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x020)); // 024665CF1628 0x20 UnitId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsForceAddList                            = GetBool(new IntPtr(p + 0x024)); // 024665CF1648 0x24 IsForceAddList              ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
