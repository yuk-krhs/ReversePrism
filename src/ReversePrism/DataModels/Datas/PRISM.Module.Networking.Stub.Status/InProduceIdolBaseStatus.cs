using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InProduceIdolBaseStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Parameter                                ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    public partial class InProduceIdolBaseStatus : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }

        public static InProduceIdolBaseStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceIdolBaseStatus() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x20 Parameter                   ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )

            return value;
        }
    }
}
