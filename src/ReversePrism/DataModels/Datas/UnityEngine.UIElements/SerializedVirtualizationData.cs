using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollOffset                             ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 FirstVisibleIndex                        ModelPrimitiveType int int int Int32
    // 01C ContentPadding                           ModelPrimitiveType float float float Single
    // 020 ContentHeight                            ModelPrimitiveType float float float Single
    // 024 AnchoredItemIndex                        ModelPrimitiveType int int int Int32
    // 028 AnchorOffset                             ModelPrimitiveType float float float Single
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

            value.ScrollOffset                              = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScrollOffset                ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.FirstVisibleIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 FirstVisibleIndex           ( ModelPrimitiveType int int int Int32 )
            value.ContentPadding                            = GetSingle(new IntPtr(p + 0x01C)); // 0x1C ContentPadding              ( ModelPrimitiveType float float float Single )
            value.ContentHeight                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 ContentHeight               ( ModelPrimitiveType float float float Single )
            value.AnchoredItemIndex                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 AnchoredItemIndex           ( ModelPrimitiveType int int int Int32 )
            value.AnchorOffset                              = GetSingle(new IntPtr(p + 0x028)); // 0x28 AnchorOffset                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
