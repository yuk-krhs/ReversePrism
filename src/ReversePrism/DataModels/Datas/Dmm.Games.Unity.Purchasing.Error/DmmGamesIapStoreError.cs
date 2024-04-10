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
    public partial class DmmGamesIapStoreError : DataModel
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
            var value   = new DmmGamesIapStoreError() { Pointer= p0 };

            value.Kind                                      = GetString(new IntPtr(p + 0x010)); // 02466B510578 0x10 Kind                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x018)); // 02466B510598 0x18 ErrorCode                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ErrorMessage                              = GetString(new IntPtr(p + 0x020)); // 02466B5105B8 0x20 ErrorMessage                ( 000186672F10 ModelPrimitiveType string string string String )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x028), ReversePrism.DataModels.Exception.FromPointer); // 02466B5105D8 0x28 Exception                   ( 0001865CB1C0 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
