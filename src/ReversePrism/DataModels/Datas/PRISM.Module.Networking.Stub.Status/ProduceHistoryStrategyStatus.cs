using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceHistoryStrategyStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceStrategyIdFieldNumber          int IL2CPP_TYPE_I4
    // 018 MstProduceStrategyId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstProduceStrategyTypeIdFieldNumber      int IL2CPP_TYPE_I4
    // 01C MstProduceStrategyTypeId                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceHistoryStrategyStatus : DataModel
    {
        public int                                      MstProduceStrategyId                    { get; set; }
        public int                                      MstProduceStrategyTypeId                { get; set; }

        public static ProduceHistoryStrategyStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceHistoryStrategyStatus() { Pointer= p0 };

            value.MstProduceStrategyId                      = GetInt32(new IntPtr(p + 0x018)); // 024661232FD8 0x18 MstProduceStrategyId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceStrategyTypeId                  = GetInt32(new IntPtr(p + 0x01C)); // 024661233018 0x1C MstProduceStrategyTypeId    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
