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
    public partial class SlotUsageEntry : DataModel
    {
        public string                                   SlotName                                { get; set; }
        public int                                      AssetId                                 { get; set; }

        public static SlotUsageEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlotUsageEntry() { Pointer= p0 };

            value.SlotName                                  = GetString(new IntPtr(p + 0x010)); // 0245A6815F78 0x10 SlotName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AssetId                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A6815F98 0x18 AssetId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
