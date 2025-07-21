using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceUnitFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProduceUnit                              ModelClassType ProduceIdolUnitStatus ProduceIdolUnitStatus ProduceIdolUnitStatus Pointer
    public partial class SetProduceUnitReply : DataModel
    {
        public ProduceIdolUnitStatus?                   ProduceUnit                             { get; set; }

        public static SetProduceUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetProduceUnitReply() { Pointer= p0 };

            value.ProduceUnit                               = GetObject<ProduceIdolUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolUnitStatus.FromPointer); // 0x18 ProduceUnit                 ( ModelClassType ProduceIdolUnitStatus ProduceIdolUnitStatus ProduceIdolUnitStatus Pointer )

            return value;
        }
    }
}
