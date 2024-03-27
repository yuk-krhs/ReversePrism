using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NLength                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 lpSecurityDescriptor                     <int> IL2CPP_TYPE_I
    // 020 BInheritHandle                           000186643FD0 ModelEnumType BOOL BOOL BOOL Int32
    public partial class SECURITY_ATTRIBUTES
    {
        public uint                                     NLength                                 { get; set; }
        public BOOL                                     BInheritHandle                          { get; set; }

        public static SECURITY_ATTRIBUTES? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SECURITY_ATTRIBUTES();

            value.NLength                                   = GetUInt32(new IntPtr(p + 0x010)); // 0270D6928EF8 0x10 NLength                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.BInheritHandle                            = (BOOL)GetInt32(new IntPtr(p + 0x020)); // 0270D6928F38 0x20 BInheritHandle              ( 000186643FD0 ModelEnumType BOOL BOOL BOOL Int32 )

            return value;
        }
    }
}
