using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 initialized                              bool IL2CPP_TYPE_BOOLEAN
    // 008 machineTrustedRootPath                   string IL2CPP_TYPE_STRING
    // 010 MachineIntermediateCAPath                000186672530 ModelPrimitiveType string string string String
    // 018 MachineUntrustedPath                     000186672530 ModelPrimitiveType string string string String
    // 020 UserTrustedRootPath                      000186672530 ModelPrimitiveType string string string String
    // 028 UserIntermediateCAPath                   000186672530 ModelPrimitiveType string string string String
    // 030 UserUntrustedPath                        000186672530 ModelPrimitiveType string string string String
    public partial class MonoBtlsX509StoreManager : DataModel
    {
        public string                                   MachineIntermediateCAPath               { get; set; }
        public string                                   MachineUntrustedPath                    { get; set; }
        public string                                   UserTrustedRootPath                     { get; set; }
        public string                                   UserIntermediateCAPath                  { get; set; }
        public string                                   UserUntrustedPath                       { get; set; }

        public static MonoBtlsX509StoreManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsX509StoreManager() { Pointer= p0 };

            value.MachineIntermediateCAPath                 = GetString(new IntPtr(p + 0x010)); // 0246679CBE70 0x10 MachineIntermediateCAPath   ( 000186672530 ModelPrimitiveType string string string String )
            value.MachineUntrustedPath                      = GetString(new IntPtr(p + 0x018)); // 0246679CBE90 0x18 MachineUntrustedPath        ( 000186672530 ModelPrimitiveType string string string String )
            value.UserTrustedRootPath                       = GetString(new IntPtr(p + 0x020)); // 0246679CBEB0 0x20 UserTrustedRootPath         ( 000186672530 ModelPrimitiveType string string string String )
            value.UserIntermediateCAPath                    = GetString(new IntPtr(p + 0x028)); // 0246679CBED0 0x28 UserIntermediateCAPath      ( 000186672530 ModelPrimitiveType string string string String )
            value.UserUntrustedPath                         = GetString(new IntPtr(p + 0x030)); // 0246679CBEF0 0x30 UserUntrustedPath           ( 000186672530 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
