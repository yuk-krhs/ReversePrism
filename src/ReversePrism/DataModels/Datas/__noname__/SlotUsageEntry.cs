using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SlotName                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 AssetId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SlotUsageEntry
    {
        public string                                   SlotName                                { get; set; }
        public int                                      AssetId                                 { get; set; }

        public static SlotUsageEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlotUsageEntry();

            value.SlotName                                  = GetString(new IntPtr(p + 0x010)); // 0270068541B0 0x10 SlotName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AssetId                                   = GetInt32(new IntPtr(p + 0x018)); // 0270068541D0 0x18 AssetId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
