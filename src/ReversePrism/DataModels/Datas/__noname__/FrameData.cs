using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Frame_count                              ModelPrimitiveType uint uint uint UInt32
    // 014 Msec                                     ModelPrimitiveType uint uint uint UInt32
    // 018 Width                                    ModelPrimitiveType float float float Single
    // 01C Height                                   ModelPrimitiveType float float float Single
    // 020 Tongue                                   ModelPrimitiveType float float float Single
    // 024 A                                        ModelPrimitiveType float float float Single
    // 028 I                                        ModelPrimitiveType float float float Single
    // 02C U                                        ModelPrimitiveType float float float Single
    // 030 E                                        ModelPrimitiveType float float float Single
    // 034 O                                        ModelPrimitiveType float float float Single
    // 038 Vol                                      ModelPrimitiveType float float float Single
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

            value.Frame_count                               = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Frame_count                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.Msec                                      = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Msec                        ( ModelPrimitiveType uint uint uint UInt32 )
            value.Width                                     = GetSingle(new IntPtr(p + 0x018)); // 0x18 Width                       ( ModelPrimitiveType float float float Single )
            value.Height                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Height                      ( ModelPrimitiveType float float float Single )
            value.Tongue                                    = GetSingle(new IntPtr(p + 0x020)); // 0x20 Tongue                      ( ModelPrimitiveType float float float Single )
            value.A                                         = GetSingle(new IntPtr(p + 0x024)); // 0x24 A                           ( ModelPrimitiveType float float float Single )
            value.I                                         = GetSingle(new IntPtr(p + 0x028)); // 0x28 I                           ( ModelPrimitiveType float float float Single )
            value.U                                         = GetSingle(new IntPtr(p + 0x02C)); // 0x2C U                           ( ModelPrimitiveType float float float Single )
            value.E                                         = GetSingle(new IntPtr(p + 0x030)); // 0x30 E                           ( ModelPrimitiveType float float float Single )
            value.O                                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 O                           ( ModelPrimitiveType float float float Single )
            value.Vol                                       = GetSingle(new IntPtr(p + 0x038)); // 0x38 Vol                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
