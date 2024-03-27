using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Years                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Months                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Days                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Hours                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Minutes                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Seconds                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Nanoseconds                              000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class XsdDuration
    {
        public int                                      Years                                   { get; set; }
        public int                                      Months                                  { get; set; }
        public int                                      Days                                    { get; set; }
        public int                                      Hours                                   { get; set; }
        public int                                      Minutes                                 { get; set; }
        public int                                      Seconds                                 { get; set; }
        public uint                                     Nanoseconds                             { get; set; }

        public static XsdDuration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdDuration();

            value.Years                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D75F3D88 0x10 Years                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Months                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D75F3DA8 0x14 Months                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Days                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D75F3DC8 0x18 Days                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Hours                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D75F3DE8 0x1C Hours                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Minutes                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D75F3E08 0x20 Minutes                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Seconds                                   = GetInt32(new IntPtr(p + 0x024)); // 0270D75F3E28 0x24 Seconds                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Nanoseconds                               = GetUInt32(new IntPtr(p + 0x028)); // 0270D75F3E48 0x28 Nanoseconds                 ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
