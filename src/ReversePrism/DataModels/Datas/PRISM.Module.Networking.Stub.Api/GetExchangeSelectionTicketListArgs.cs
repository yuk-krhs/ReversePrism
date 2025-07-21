using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetExchangeSelectionTicketListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSelectionTicketIdFieldNumber          int IL2CPP_TYPE_I4
    // 018 MstSelectionTicketId                     ModelPrimitiveType int int int Int32
    // 000 ProductTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 01C ProductType                              ModelEnumType ProductType ProductType ProductType Int32
    // 000 ProductMstIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 ProductMstId                             ModelPrimitiveType int int int Int32
    public partial class GetExchangeSelectionTicketListArgs : DataModel
    {
        public int                                      MstSelectionTicketId                    { get; set; }
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }

        public static GetExchangeSelectionTicketListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangeSelectionTicketListArgs() { Pointer= p0 };

            value.MstSelectionTicketId                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSelectionTicketId        ( ModelPrimitiveType int int int Int32 )
            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ProductType                 ( ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 ProductMstId                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
