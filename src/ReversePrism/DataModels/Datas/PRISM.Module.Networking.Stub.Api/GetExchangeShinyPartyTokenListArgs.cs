using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetExchangeShinyPartyTokenListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProductTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProductType                              0001865A5C10 ModelEnumType ProductType ProductType ProductType Int32
    // 000 ProductMstIdFieldNumber                  int IL2CPP_TYPE_I4
    // 01C ProductMstId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetExchangeShinyPartyTokenListArgs
    {
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }

        public static GetExchangeShinyPartyTokenListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangeShinyPartyTokenListArgs();

            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x018)); // 0270D12225B0 0x18 ProductType                 ( 0001865A5C10 ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x01C)); // 0270D12225F0 0x1C ProductMstId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
