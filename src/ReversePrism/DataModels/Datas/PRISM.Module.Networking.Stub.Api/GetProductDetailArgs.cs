using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProductDetailArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProductType                              ModelEnumType ProductType ProductType ProductType Int32
    // 000 ProductMstIdFieldNumber                  int IL2CPP_TYPE_I4
    // 01C ProductMstId                             ModelPrimitiveType int int int Int32
    public partial class GetProductDetailArgs : DataModel
    {
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }

        public static GetProductDetailArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProductDetailArgs() { Pointer= p0 };

            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ProductType                 ( ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ProductMstId                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
