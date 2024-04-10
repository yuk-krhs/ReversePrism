using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetExchangePurchaseHistoryListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstExchangeGroupIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstExchangeGroupId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetExchangePurchaseHistoryListArgs : DataModel
    {
        public int                                      MstExchangeGroupId                      { get; set; }

        public static GetExchangePurchaseHistoryListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangePurchaseHistoryListArgs() { Pointer= p0 };

            value.MstExchangeGroupId                        = GetInt32(new IntPtr(p + 0x018)); // 024661195690 0x18 MstExchangeGroupId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
