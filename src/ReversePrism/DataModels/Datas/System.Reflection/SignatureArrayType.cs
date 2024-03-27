using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Rank                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 024 IsMultiDim                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class SignatureArrayType
    {
        public int                                      Rank                                    { get; set; }
        public bool                                     IsMultiDim                              { get; set; }

        public static SignatureArrayType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignatureArrayType();

            value.Rank                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D6CEA500 0x20 Rank                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsMultiDim                                = GetBool(new IntPtr(p + 0x024)); // 0270D6CEA520 0x24 IsMultiDim                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
