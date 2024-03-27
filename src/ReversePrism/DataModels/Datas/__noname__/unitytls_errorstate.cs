using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Magic                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 014 Code                                     0001866AD270 ModelEnumType unitytls_error_code unitytls_error_code unitytls_error_code Int32
    // 018 Reserved                                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class unitytls_errorstate
    {
        public uint                                     Magic                                   { get; set; }
        public unitytls_error_code                      Code                                    { get; set; }
        public ulong                                    Reserved                                { get; set; }

        public static unitytls_errorstate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_errorstate();

            value.Magic                                     = GetUInt32(new IntPtr(p + 0x010)); // 0270D78E96E0 0x10 Magic                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Code                                      = (unitytls_error_code)GetInt32(new IntPtr(p + 0x014)); // 0270D78E9700 0x14 Code                        ( 0001866AD270 ModelEnumType unitytls_error_code unitytls_error_code unitytls_error_code Int32 )
            value.Reserved                                  = GetUInt64(new IntPtr(p + 0x018)); // 0270D78E9720 0x18 Reserved                    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
