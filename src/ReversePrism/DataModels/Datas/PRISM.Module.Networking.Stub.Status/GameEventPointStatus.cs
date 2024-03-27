using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GameEventPointStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EventPointFieldNumber                    int IL2CPP_TYPE_I4
    // 020 EventPoint                               0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class GameEventPointStatus
    {
        public int                                      MstEventId                              { get; set; }
        public ProductWithAmountStatus?                 EventPoint                              { get; set; }

        public static GameEventPointStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameEventPointStatus();

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0270D13819C8 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EventPoint                                = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1381A08 0x20 EventPoint                  ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
