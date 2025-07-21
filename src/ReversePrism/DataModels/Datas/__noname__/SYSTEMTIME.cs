using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Year                                     ModelPrimitiveType ushort ushort ushort UInt16
    // 012 Month                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 014 DayOfWeek                                ModelPrimitiveType ushort ushort ushort UInt16
    // 016 Day                                      ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Hour                                     ModelPrimitiveType ushort ushort ushort UInt16
    // 01A Minute                                   ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Second                                   ModelPrimitiveType ushort ushort ushort UInt16
    // 01E Milliseconds                             ModelPrimitiveType ushort ushort ushort UInt16
    public partial class SYSTEMTIME : DataModel
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
            var value   = new SYSTEMTIME() { Pointer= p0 };

            value.Year                                      = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Year                        ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Month                                     = GetUInt16(new IntPtr(p + 0x012)); // 0x12 Month                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DayOfWeek                                 = GetUInt16(new IntPtr(p + 0x014)); // 0x14 DayOfWeek                   ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Day                                       = GetUInt16(new IntPtr(p + 0x016)); // 0x16 Day                         ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Hour                                      = GetUInt16(new IntPtr(p + 0x018)); // 0x18 Hour                        ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Minute                                    = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A Minute                      ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Second                                    = GetUInt16(new IntPtr(p + 0x01C)); // 0x1C Second                      ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Milliseconds                              = GetUInt16(new IntPtr(p + 0x01E)); // 0x1E Milliseconds                ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
