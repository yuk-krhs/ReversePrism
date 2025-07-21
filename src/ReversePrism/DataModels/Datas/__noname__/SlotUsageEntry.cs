using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SlotName                                 ModelPrimitiveType string string string String
    // 018 AssetId                                  ModelPrimitiveType int int int Int32
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

            value.SlotName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 SlotName                    ( ModelPrimitiveType string string string String )
            value.AssetId                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 AssetId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
