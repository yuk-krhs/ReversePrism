using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 000 ExpectedReportId                         sbyte IL2CPP_TYPE_U1
    // 010 ReportId                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Buttons0                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Buttons1                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Hat                                      ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 LeftX                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 016 LeftY                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 018 RightX                                   ModelPrimitiveType ushort ushort ushort UInt16
    // 01A RightY                                   ModelPrimitiveType ushort ushort ushort UInt16
    public partial class SwitchSimpleInputReport : DataModel
    {
        public sbyte                                    ReportId                                { get; set; }
        public sbyte                                    Buttons0                                { get; set; }
        public sbyte                                    Buttons1                                { get; set; }
        public sbyte                                    Hat                                     { get; set; }
        public ushort                                   LeftX                                   { get; set; }
        public ushort                                   LeftY                                   { get; set; }
        public ushort                                   RightX                                  { get; set; }
        public ushort                                   RightY                                  { get; set; }

        public static SwitchSimpleInputReport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchSimpleInputReport() { Pointer= p0 };

            value.ReportId                                  = GetSByte(new IntPtr(p + 0x010)); // 0x10 ReportId                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons0                                  = GetSByte(new IntPtr(p + 0x011)); // 0x11 Buttons0                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Buttons1                                  = GetSByte(new IntPtr(p + 0x012)); // 0x12 Buttons1                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Hat                                       = GetSByte(new IntPtr(p + 0x013)); // 0x13 Hat                         ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.LeftX                                     = GetUInt16(new IntPtr(p + 0x014)); // 0x14 LeftX                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.LeftY                                     = GetUInt16(new IntPtr(p + 0x016)); // 0x16 LeftY                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.RightX                                    = GetUInt16(new IntPtr(p + 0x018)); // 0x18 RightX                      ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.RightY                                    = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A RightY                      ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
