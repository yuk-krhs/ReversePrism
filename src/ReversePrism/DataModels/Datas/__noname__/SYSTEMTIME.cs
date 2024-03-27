using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Year                                     000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Month                                    000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 DayOfWeek                                000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Day                                      000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Hour                                     000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A Minute                                   000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Second                                   000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E Milliseconds                             000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class SYSTEMTIME
    {
        public ushort                                   Year                                    { get; set; }
        public ushort                                   Month                                   { get; set; }
        public ushort                                   DayOfWeek                               { get; set; }
        public ushort                                   Day                                     { get; set; }
        public ushort                                   Hour                                    { get; set; }
        public ushort                                   Minute                                  { get; set; }
        public ushort                                   Second                                  { get; set; }
        public ushort                                   Milliseconds                            { get; set; }

        public static SYSTEMTIME? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SYSTEMTIME();

            value.Year                                      = GetUInt16(new IntPtr(p + 0x010)); // 0270D69283D8 0x10 Year                        ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Month                                     = GetUInt16(new IntPtr(p + 0x012)); // 0270D69283F8 0x12 Month                       ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DayOfWeek                                 = GetUInt16(new IntPtr(p + 0x014)); // 0270D6928418 0x14 DayOfWeek                   ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Day                                       = GetUInt16(new IntPtr(p + 0x016)); // 0270D6928438 0x16 Day                         ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Hour                                      = GetUInt16(new IntPtr(p + 0x018)); // 0270D6928458 0x18 Hour                        ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Minute                                    = GetUInt16(new IntPtr(p + 0x01A)); // 0270D6928478 0x1A Minute                      ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Second                                    = GetUInt16(new IntPtr(p + 0x01C)); // 0270D6928498 0x1C Second                      ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Milliseconds                              = GetUInt16(new IntPtr(p + 0x01E)); // 0270D69284B8 0x1E Milliseconds                ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
