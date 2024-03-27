using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Kind                                     000186672F10 ModelPrimitiveType string string string String
    // 018 ErrorCode                                0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ErrorMessage                             000186672F10 ModelPrimitiveType string string string String
    // 028 Exception                                0001865CB1C0 ModelClassType Exception Exception Exception Pointer
    public partial class DmmGamesIapStoreError
    {
        public string                                   Kind                                    { get; set; }
        public int                                      ErrorCode                               { get; set; }
        public string                                   ErrorMessage                            { get; set; }
        public Exception?                               Exception                               { get; set; }

        public static DmmGamesIapStoreError? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapStoreError();

            value.Kind                                      = GetString(new IntPtr(p + 0x010)); // 0270DB483648 0x10 Kind                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x018)); // 0270DB483668 0x18 ErrorCode                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ErrorMessage                              = GetString(new IntPtr(p + 0x020)); // 0270DB483688 0x20 ErrorMessage                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x028), ReversePrism.DataModels.Exception.FromPointer); // 0270DB4836A8 0x28 Exception                   ( 0001865CB1C0 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
