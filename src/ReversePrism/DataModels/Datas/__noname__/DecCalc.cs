using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TenToPowerNine                           uint IL2CPP_TYPE_U4
    // 010 Uflags                                   ModelPrimitiveType uint uint uint UInt32
    // 014 Uhi                                      ModelPrimitiveType uint uint uint UInt32
    // 018 Ulo                                      ModelPrimitiveType uint uint uint UInt32
    // 01C Umid                                     ModelPrimitiveType uint uint uint UInt32
    // 018 UlomidLE                                 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class DecCalc : DataModel
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
            var value   = new DecCalc() { Pointer= p0 };

            value.Uflags                                    = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Uflags                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.Uhi                                       = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Uhi                         ( ModelPrimitiveType uint uint uint UInt32 )
            value.Ulo                                       = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Ulo                         ( ModelPrimitiveType uint uint uint UInt32 )
            value.Umid                                      = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C Umid                        ( ModelPrimitiveType uint uint uint UInt32 )
            value.UlomidLE                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 UlomidLE                    ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
