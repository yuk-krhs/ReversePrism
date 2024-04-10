using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Frame_count                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Msec                                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Width                                    000186666050 ModelPrimitiveType float float float Single
    // 01C Height                                   000186666050 ModelPrimitiveType float float float Single
    // 020 Tongue                                   000186666050 ModelPrimitiveType float float float Single
    // 024 A                                        000186666050 ModelPrimitiveType float float float Single
    // 028 I                                        000186666050 ModelPrimitiveType float float float Single
    // 02C U                                        000186666050 ModelPrimitiveType float float float Single
    // 030 E                                        000186666050 ModelPrimitiveType float float float Single
    // 034 O                                        000186666050 ModelPrimitiveType float float float Single
    // 038 Vol                                      000186666050 ModelPrimitiveType float float float Single
    public partial class FrameData : DataModel
    {
        public uint                                     Frame_count                             { get; set; }
        public uint                                     Msec                                    { get; set; }
        public float                                    Width                                   { get; set; }
        public float                                    Height                                  { get; set; }
        public float                                    Tongue                                  { get; set; }
        public float                                    A                                       { get; set; }
        public float                                    I                                       { get; set; }
        public float                                    U                                       { get; set; }
        public float                                    E                                       { get; set; }
        public float                                    O                                       { get; set; }
        public float                                    Vol                                     { get; set; }

        public static FrameData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameData() { Pointer= p0 };

            value.Frame_count                               = GetUInt32(new IntPtr(p + 0x010)); // 02466BC42158 0x10 Frame_count                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Msec                                      = GetUInt32(new IntPtr(p + 0x014)); // 02466BC42178 0x14 Msec                        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Width                                     = GetSingle(new IntPtr(p + 0x018)); // 02466BC42198 0x18 Width                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Height                                    = GetSingle(new IntPtr(p + 0x01C)); // 02466BC421B8 0x1C Height                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Tongue                                    = GetSingle(new IntPtr(p + 0x020)); // 02466BC421D8 0x20 Tongue                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.A                                         = GetSingle(new IntPtr(p + 0x024)); // 02466BC421F8 0x24 A                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.I                                         = GetSingle(new IntPtr(p + 0x028)); // 02466BC42218 0x28 I                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.U                                         = GetSingle(new IntPtr(p + 0x02C)); // 02466BC42238 0x2C U                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.E                                         = GetSingle(new IntPtr(p + 0x030)); // 02466BC42258 0x30 E                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.O                                         = GetSingle(new IntPtr(p + 0x034)); // 02466BC42278 0x34 O                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Vol                                       = GetSingle(new IntPtr(p + 0x038)); // 02466BC42298 0x38 Vol                         ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
