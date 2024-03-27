using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Word                                     0001866731A0 ModelPrimitiveType string string string String
    // 018 Token                                    00018668A420 ModelEnumType Tokens Tokens Tokens Int32
    // 01C Op                                       0001865F44E0 ModelPrimitiveType int int int Int32
    public partial class ReservedWords
    {
        public string                                   Word                                    { get; set; }
        public Tokens                                   Token                                   { get; set; }
        public int                                      Op                                      { get; set; }

        public static ReservedWords? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReservedWords();

            value.Word                                      = GetString(new IntPtr(p + 0x010)); // 0270D8929BE0 0x10 Word                        ( 0001866731A0 ModelPrimitiveType string string string String )
            value.Token                                     = (Tokens)GetInt32(new IntPtr(p + 0x018)); // 0270D8929C00 0x18 Token                       ( 00018668A420 ModelEnumType Tokens Tokens Tokens Int32 )
            value.Op                                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D8929C20 0x1C Op                          ( 0001865F44E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
