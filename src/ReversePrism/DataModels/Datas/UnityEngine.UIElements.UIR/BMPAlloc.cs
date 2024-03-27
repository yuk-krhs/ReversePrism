using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Invalid                                  BMPAlloc IL2CPP_TYPE_VALUETYPE
    // 010 Page                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 PageLine                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 BitIndex                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 OwnedState                               000186700230 ModelEnumType OwnedState OwnedState OwnedState Int32
    public partial class BMPAlloc
    {
        public int                                      Page                                    { get; set; }
        public ushort                                   PageLine                                { get; set; }
        public sbyte                                    BitIndex                                { get; set; }
        public OwnedState                               OwnedState                              { get; set; }

        public static BMPAlloc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BMPAlloc();

            value.Page                                      = GetInt32(new IntPtr(p + 0x010)); // 027003F08F30 0x10 Page                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PageLine                                  = GetUInt16(new IntPtr(p + 0x014)); // 027003F08F50 0x14 PageLine                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.BitIndex                                  = GetSByte(new IntPtr(p + 0x016)); // 027003F08F70 0x16 BitIndex                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.OwnedState                                = (OwnedState)GetInt32(new IntPtr(p + 0x017)); // 027003F08F90 0x17 OwnedState                  ( 000186700230 ModelEnumType OwnedState OwnedState OwnedState Int32 )

            return value;
        }
    }
}
