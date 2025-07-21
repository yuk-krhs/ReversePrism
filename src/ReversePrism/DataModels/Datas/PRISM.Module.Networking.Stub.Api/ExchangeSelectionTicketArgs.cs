using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExchangeSelectionTicketArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSelectionTicketIdFieldNumber          int IL2CPP_TYPE_I4
    // 018 MstSelectionTicketId                     ModelPrimitiveType int int int Int32
    // 000 MstSelectionTicketProductIdFieldNumber   int IL2CPP_TYPE_I4
    // 01C MstSelectionTicketProductId              ModelPrimitiveType int int int Int32
    public partial class ExchangeSelectionTicketArgs : DataModel
    {
        public int                                      MstSelectionTicketId                    { get; set; }
        public int                                      MstSelectionTicketProductId             { get; set; }

        public static ExchangeSelectionTicketArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionTicketArgs() { Pointer= p0 };

            value.MstSelectionTicketId                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSelectionTicketId        ( ModelPrimitiveType int int int Int32 )
            value.MstSelectionTicketProductId               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstSelectionTicketProductId ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
