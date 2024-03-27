using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TenToPowerNine                           uint IL2CPP_TYPE_U4
    // 010 Uflags                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Uhi                                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Ulo                                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C Umid                                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 UlomidLE                                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class DecCalc
    {
        public uint                                     Uflags                                  { get; set; }
        public uint                                     Uhi                                     { get; set; }
        public uint                                     Ulo                                     { get; set; }
        public uint                                     Umid                                    { get; set; }
        public ulong                                    UlomidLE                                { get; set; }

        public static DecCalc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecCalc();

            value.Uflags                                    = GetUInt32(new IntPtr(p + 0x010)); // 0270DAAA8A90 0x10 Uflags                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Uhi                                       = GetUInt32(new IntPtr(p + 0x014)); // 0270DAAA8AB0 0x14 Uhi                         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Ulo                                       = GetUInt32(new IntPtr(p + 0x018)); // 0270DAAA8AD0 0x18 Ulo                         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Umid                                      = GetUInt32(new IntPtr(p + 0x01C)); // 0270DAAA8AF0 0x1C Umid                        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.UlomidLE                                  = GetUInt64(new IntPtr(p + 0x018)); // 0270DAAA8B10 0x18 UlomidLE                    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
