using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PurchaseExchangeProductArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstExchangeProductIdFieldNumber          int IL2CPP_TYPE_I4
    // 018 MstExchangeProductId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PurchaseExchangeProductArgs : DataModel
    {
        public int                                      MstExchangeProductId                    { get; set; }
        public int                                      Amount                                  { get; set; }

        public static PurchaseExchangeProductArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseExchangeProductArgs() { Pointer= p0 };

            value.MstExchangeProductId                      = GetInt32(new IntPtr(p + 0x018)); // 02466119BA80 0x18 MstExchangeProductId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x01C)); // 02466119BAC0 0x1C Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
