using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Rank                                     ModelPrimitiveType int int int Int32
    // 024 IsMultiDim                               ModelPrimitiveType bool bool bool Bool
    public partial class SignatureArrayType : DataModel
    {
        public int                                      Rank                                    { get; set; }
        public bool                                     IsMultiDim                              { get; set; }

        public static SignatureArrayType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignatureArrayType() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.IsMultiDim                                = GetBool(new IntPtr(p + 0x024)); // 0x24 IsMultiDim                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
