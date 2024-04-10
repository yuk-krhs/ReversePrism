using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   000186671BA0 ModelPrimitiveType string string string String
    // 018 Operation                                0001865D04B0 ModelEnumType FtpOperation FtpOperation FtpOperation Int32
    // 01C Flags                                    0001865CFA30 ModelEnumType FtpMethodFlags FtpMethodFlags FtpMethodFlags Int32
    // 020 HttpCommand                              000186671BA0 ModelPrimitiveType string string string String
    // 000 s_knownMethodInfo                        FtpMethodInfo[] IL2CPP_TYPE_SZARRAY
    public partial class FtpMethodInfo : DataModel
    {
        public string                                   Method                                  { get; set; }
        public FtpOperation                             Operation                               { get; set; }
        public FtpMethodFlags                           Flags                                   { get; set; }
        public string                                   HttpCommand                             { get; set; }

        public static FtpMethodInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FtpMethodInfo() { Pointer= p0 };

            value.Method                                    = GetString(new IntPtr(p + 0x010)); // 024667A6BB50 0x10 Method                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Operation                                 = (FtpOperation)GetInt32(new IntPtr(p + 0x018)); // 024667A6BB70 0x18 Operation                   ( 0001865D04B0 ModelEnumType FtpOperation FtpOperation FtpOperation Int32 )
            value.Flags                                     = (FtpMethodFlags)GetInt32(new IntPtr(p + 0x01C)); // 024667A6BB90 0x1C Flags                       ( 0001865CFA30 ModelEnumType FtpMethodFlags FtpMethodFlags FtpMethodFlags Int32 )
            value.HttpCommand                               = GetString(new IntPtr(p + 0x020)); // 024667A6BBB0 0x20 HttpCommand                 ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
