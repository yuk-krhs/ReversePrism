using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolSkillActionConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceActionConditionTypeIdFieldNumber int IL2CPP_TYPE_I4
    // 018 MstProduceActionConditionTypeId          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ConditionValueFieldNumber                int IL2CPP_TYPE_I4
    // 01C ConditionValue                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IdolSkillActionConditionStatus
    {
        public int                                      MstProduceActionConditionTypeId         { get; set; }
        public int                                      ConditionValue                          { get; set; }

        public static IdolSkillActionConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillActionConditionStatus();

            value.MstProduceActionConditionTypeId           = GetInt32(new IntPtr(p + 0x018)); // 0270041B8208 0x18 MstProduceActionConditionTypeId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x01C)); // 0270041B8248 0x1C ConditionValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
