using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceActionConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceActionConditionTypeIdFieldNumber int IL2CPP_TYPE_I4
    // 018 MstProduceActionConditionTypeId          ModelPrimitiveType int int int Int32
    // 000 ConditionValueFieldNumber                int IL2CPP_TYPE_I4
    // 01C ConditionValue                           ModelPrimitiveType int int int Int32
    public partial class ProduceActionConditionStatus : DataModel
    {
        public int                                      MstProduceActionConditionTypeId         { get; set; }
        public int                                      ConditionValue                          { get; set; }

        public static ProduceActionConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceActionConditionStatus() { Pointer= p0 };

            value.MstProduceActionConditionTypeId           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceActionConditionTypeId ( ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ConditionValue              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
