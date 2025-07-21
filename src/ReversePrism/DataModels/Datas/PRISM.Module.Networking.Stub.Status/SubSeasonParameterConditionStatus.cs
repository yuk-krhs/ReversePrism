using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonParameterConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsConditionFieldNumber                   int IL2CPP_TYPE_I4
    // 018 IsCondition                              ModelPrimitiveType bool bool bool Bool
    // 000 RequiredUnitParameterFieldNumber         int IL2CPP_TYPE_I4
    // 020 RequiredUnitParameter                    ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 UnitParameterFieldNumber                 int IL2CPP_TYPE_I4
    // 028 UnitParameter                            ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 MeetConditionFieldNumber                 int IL2CPP_TYPE_I4
    // 030 MeetCondition                            ModelPrimitiveType bool bool bool Bool
    public partial class SubSeasonParameterConditionStatus : DataModel
    {
        public bool                                     IsCondition                             { get; set; }
        public ProduceParameterStatus?                  RequiredUnitParameter                   { get; set; }
        public ProduceParameterStatus?                  UnitParameter                           { get; set; }
        public bool                                     MeetCondition                           { get; set; }

        public static SubSeasonParameterConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonParameterConditionStatus() { Pointer= p0 };

            value.IsCondition                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsCondition                 ( ModelPrimitiveType bool bool bool Bool )
            value.RequiredUnitParameter                     = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x20 RequiredUnitParameter       ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.UnitParameter                             = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x28 UnitParameter               ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.MeetCondition                             = GetBool(new IntPtr(p + 0x030)); // 0x30 MeetCondition               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
