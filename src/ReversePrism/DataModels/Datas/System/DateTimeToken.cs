using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dtt                                      00018657D3E0 ModelEnumType DTT DTT DTT Int32
    // 014 Suffix                                   00018668DA40 ModelEnumType TokenType TokenType TokenType Int32
    // 018 Num                                      0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class DateTimeToken
    {
        public DTT                                      Dtt                                     { get; set; }
        public TokenType                                Suffix                                  { get; set; }
        public int                                      Num                                     { get; set; }

        public static DateTimeToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeToken();

            value.Dtt                                       = (DTT)GetInt32(new IntPtr(p + 0x010)); // 0270D6994A60 0x10 Dtt                         ( 00018657D3E0 ModelEnumType DTT DTT DTT Int32 )
            value.Suffix                                    = (TokenType)GetInt32(new IntPtr(p + 0x014)); // 0270D6994A80 0x14 Suffix                      ( 00018668DA40 ModelEnumType TokenType TokenType TokenType Int32 )
            value.Num                                       = GetInt32(new IntPtr(p + 0x018)); // 0270D6994AA0 0x18 Num                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
