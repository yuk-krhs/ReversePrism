using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollOffset                             0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 FirstVisibleIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ContentPadding                           000186666050 ModelPrimitiveType float float float Single
    // 020 ContentHeight                            000186666050 ModelPrimitiveType float float float Single
    // 024 AnchoredItemIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 AnchorOffset                             000186666050 ModelPrimitiveType float float float Single
    public partial class SerializedVirtualizationData : DataModel
    {
        public Vector2                                  ScrollOffset                            { get; set; }
        public int                                      FirstVisibleIndex                       { get; set; }
        public float                                    ContentPadding                          { get; set; }
        public float                                    ContentHeight                           { get; set; }
        public int                                      AnchoredItemIndex                       { get; set; }
        public float                                    AnchorOffset                            { get; set; }

        public static SerializedVirtualizationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializedVirtualizationData() { Pointer= p0 };

            value.ScrollOffset                              = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0245A66BCAE8 0x10 ScrollOffset                ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.FirstVisibleIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0245A66BCB08 0x18 FirstVisibleIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ContentPadding                            = GetSingle(new IntPtr(p + 0x01C)); // 0245A66BCB28 0x1C ContentPadding              ( 000186666050 ModelPrimitiveType float float float Single )
            value.ContentHeight                             = GetSingle(new IntPtr(p + 0x020)); // 0245A66BCB48 0x20 ContentHeight               ( 000186666050 ModelPrimitiveType float float float Single )
            value.AnchoredItemIndex                         = GetInt32(new IntPtr(p + 0x024)); // 0245A66BCB68 0x24 AnchoredItemIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AnchorOffset                              = GetSingle(new IntPtr(p + 0x028)); // 0245A66BCB88 0x28 AnchorOffset                ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
