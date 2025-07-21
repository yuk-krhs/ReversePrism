using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Word                                     ModelPrimitiveType string string string String
    // 018 Token                                    ModelEnumType Tokens Tokens Tokens Int32
    // 01C Op                                       ModelPrimitiveType int int int Int32
    public partial class ReservedWords : DataModel
    {
        public string                                   Word                                    { get; set; }
        public Tokens                                   Token                                   { get; set; }
        public int                                      Op                                      { get; set; }

        public static ReservedWords? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReservedWords() { Pointer= p0 };

            value.Word                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Word                        ( ModelPrimitiveType string string string String )
            value.Token                                     = (Tokens)GetInt32(new IntPtr(p + 0x018)); // 0x18 Token                       ( ModelEnumType Tokens Tokens Tokens Int32 )
            value.Op                                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Op                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
