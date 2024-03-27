using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 X                                        000186666050 ModelPrimitiveType float float float Single
    // 018 Y                                        000186666050 ModelPrimitiveType float float float Single
    // 01C Width                                    000186666050 ModelPrimitiveType float float float Single
    // 020 Height                                   000186666050 ModelPrimitiveType float float float Single
    // 024 XOffset                                  000186666050 ModelPrimitiveType float float float Single
    // 028 YOffset                                  000186666050 ModelPrimitiveType float float float Single
    // 02C XAdvance                                 000186666050 ModelPrimitiveType float float float Single
    // 030 Scale                                    000186666050 ModelPrimitiveType float float float Single
    public partial class TMP_TextElement_Legacy
    {
        public int                                      Id                                      { get; set; }
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    Width                                   { get; set; }
        public float                                    Height                                  { get; set; }
        public float                                    XOffset                                 { get; set; }
        public float                                    YOffset                                 { get; set; }
        public float                                    XAdvance                                { get; set; }
        public float                                    Scale                                   { get; set; }

        public static TMP_TextElement_Legacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_TextElement_Legacy();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D09DF610 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.X                                         = GetSingle(new IntPtr(p + 0x014)); // 0270D09DF630 0x14 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x018)); // 0270D09DF650 0x18 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x01C)); // 0270D09DF670 0x1C Width                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Height                                    = GetSingle(new IntPtr(p + 0x020)); // 0270D09DF690 0x20 Height                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.XOffset                                   = GetSingle(new IntPtr(p + 0x024)); // 0270D09DF6B0 0x24 XOffset                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.YOffset                                   = GetSingle(new IntPtr(p + 0x028)); // 0270D09DF6D0 0x28 YOffset                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.XAdvance                                  = GetSingle(new IntPtr(p + 0x02C)); // 0270D09DF6F0 0x2C XAdvance                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x030)); // 0270D09DF710 0x30 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
