using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Guid                                     0001865DC380 ModelEnumType Guid Guid Guid Int32
    // 010 Byte00                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 Byte01                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 Byte02                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 Byte03                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 Byte04                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 Byte05                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 Byte06                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 Byte07                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 Byte08                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 Byte09                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01A Byte10                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01B Byte11                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01C Byte12                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D Byte13                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E Byte14                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F Byte15                                   00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DecomposedGuid
    {
        public Guid                                     Guid                                    { get; set; }
        public sbyte                                    Byte00                                  { get; set; }
        public sbyte                                    Byte01                                  { get; set; }
        public sbyte                                    Byte02                                  { get; set; }
        public sbyte                                    Byte03                                  { get; set; }
        public sbyte                                    Byte04                                  { get; set; }
        public sbyte                                    Byte05                                  { get; set; }
        public sbyte                                    Byte06                                  { get; set; }
        public sbyte                                    Byte07                                  { get; set; }
        public sbyte                                    Byte08                                  { get; set; }
        public sbyte                                    Byte09                                  { get; set; }
        public sbyte                                    Byte10                                  { get; set; }
        public sbyte                                    Byte11                                  { get; set; }
        public sbyte                                    Byte12                                  { get; set; }
        public sbyte                                    Byte13                                  { get; set; }
        public sbyte                                    Byte14                                  { get; set; }
        public sbyte                                    Byte15                                  { get; set; }

        public static DecomposedGuid? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecomposedGuid();

            value.Guid                                      = (Guid)GetInt32(new IntPtr(p + 0x010)); // 0270D6E18B18 0x10 Guid                        ( 0001865DC380 ModelEnumType Guid Guid Guid Int32 )
            value.Byte00                                    = GetSByte(new IntPtr(p + 0x010)); // 0270D6E18B38 0x10 Byte00                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte01                                    = GetSByte(new IntPtr(p + 0x011)); // 0270D6E18B58 0x11 Byte01                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte02                                    = GetSByte(new IntPtr(p + 0x012)); // 0270D6E18B78 0x12 Byte02                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte03                                    = GetSByte(new IntPtr(p + 0x013)); // 0270D6E18B98 0x13 Byte03                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte04                                    = GetSByte(new IntPtr(p + 0x014)); // 0270D6E18BB8 0x14 Byte04                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte05                                    = GetSByte(new IntPtr(p + 0x015)); // 0270D6E18BD8 0x15 Byte05                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte06                                    = GetSByte(new IntPtr(p + 0x016)); // 0270D6E18BF8 0x16 Byte06                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte07                                    = GetSByte(new IntPtr(p + 0x017)); // 0270D6E18C18 0x17 Byte07                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte08                                    = GetSByte(new IntPtr(p + 0x018)); // 0270D6E18C38 0x18 Byte08                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte09                                    = GetSByte(new IntPtr(p + 0x019)); // 0270D6E18C58 0x19 Byte09                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte10                                    = GetSByte(new IntPtr(p + 0x01A)); // 0270D6E18C78 0x1A Byte10                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte11                                    = GetSByte(new IntPtr(p + 0x01B)); // 0270D6E18C98 0x1B Byte11                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte12                                    = GetSByte(new IntPtr(p + 0x01C)); // 0270D6E18CB8 0x1C Byte12                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte13                                    = GetSByte(new IntPtr(p + 0x01D)); // 0270D6E18CD8 0x1D Byte13                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte14                                    = GetSByte(new IntPtr(p + 0x01E)); // 0270D6E18CF8 0x1E Byte14                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte15                                    = GetSByte(new IntPtr(p + 0x01F)); // 0270D6E18D18 0x1F Byte15                      ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
