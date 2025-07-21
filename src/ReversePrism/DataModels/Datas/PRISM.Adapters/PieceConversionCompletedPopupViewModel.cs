using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductKey                               ModelEnumType ProductKey ProductKey ProductKey Int32
    // 018 BeforePoint                              ModelPrimitiveType long long long Int64
    // 020 AfterPoint                               ModelPrimitiveType long long long Int64
    public partial class PieceConversionCompletedPopupViewModel : DataModel
    {
        public ProductKey                               ProductKey                              { get; set; }
        public long                                     BeforePoint                             { get; set; }
        public long                                     AfterPoint                              { get; set; }

        public static PieceConversionCompletedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceConversionCompletedPopupViewModel() { Pointer= p0 };

            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 ProductKey                  ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.BeforePoint                               = GetInt64(new IntPtr(p + 0x018)); // 0x18 BeforePoint                 ( ModelPrimitiveType long long long Int64 )
            value.AfterPoint                                = GetInt64(new IntPtr(p + 0x020)); // 0x20 AfterPoint                  ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
