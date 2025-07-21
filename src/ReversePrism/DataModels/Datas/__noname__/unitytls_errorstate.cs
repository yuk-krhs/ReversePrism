using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Magic                                    ModelPrimitiveType uint uint uint UInt32
    // 014 Code                                     ModelEnumType unitytls_error_code unitytls_error_code unitytls_error_code Int32
    // 018 Reserved                                 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class unitytls_errorstate : DataModel
    {
        public uint                                     Magic                                   { get; set; }
        public unitytls_error_code                      Code                                    { get; set; }
        public ulong                                    Reserved                                { get; set; }

        public static unitytls_errorstate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_errorstate() { Pointer= p0 };

            value.Magic                                     = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Magic                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Code                                      = (unitytls_error_code)GetInt32(new IntPtr(p + 0x014)); // 0x14 Code                        ( ModelEnumType unitytls_error_code unitytls_error_code unitytls_error_code Int32 )
            value.Reserved                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Reserved                    ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
