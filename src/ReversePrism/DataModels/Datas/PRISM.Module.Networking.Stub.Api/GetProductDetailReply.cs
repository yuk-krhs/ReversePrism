using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProductDetailReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductDetailFieldNumber                 int IL2CPP_TYPE_I4
    // 018 ProductDetail                            0001865A12F0 ModelClassType ProductDetailStatus ProductDetailStatus ProductDetailStatus Pointer
    public partial class GetProductDetailReply
    {
        public ProductDetailStatus?                     ProductDetail                           { get; set; }

        public static GetProductDetailReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProductDetailReply();

            value.ProductDetail                             = GetObject<ProductDetailStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductDetailStatus.FromPointer); // 0270D266F288 0x18 ProductDetail               ( 0001865A12F0 ModelClassType ProductDetailStatus ProductDetailStatus ProductDetailStatus Pointer )

            return value;
        }
    }
}
