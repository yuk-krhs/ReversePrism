using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Time                                     ModelPrimitiveType float float float Single
    // 014 IsCut                                    ModelPrimitiveType bool bool bool Bool
    // 018 Item                                     ModelEnumType Item Item Item Int32
    public partial class RecordingItem : DataModel
    {
        public float                                    Time                                    { get; set; }
        public bool                                     IsCut                                   { get; set; }
        public Item                                     Item                                    { get; set; }

        public static RecordingItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecordingItem() { Pointer= p0 };

            value.Time                                      = GetSingle(new IntPtr(p + 0x010)); // 0x10 Time                        ( ModelPrimitiveType float float float Single )
            value.IsCut                                     = GetBool(new IntPtr(p + 0x014)); // 0x14 IsCut                       ( ModelPrimitiveType bool bool bool Bool )
            value.Item                                      = (Item)GetInt32(new IntPtr(p + 0x018)); // 0x18 Item                        ( ModelEnumType Item Item Item Int32 )

            return value;
        }
    }
}
