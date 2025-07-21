using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BuildUpParameterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScheduleValueFieldNumber                 int IL2CPP_TYPE_I4
    // 018 ScheduleValue                            ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer
    // 000 SupportBonusValueFieldNumber             int IL2CPP_TYPE_I4
    // 020 SupportBonusValue                        ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer
    public partial class BuildUpParameterStatus : DataModel
    {
        public BuildUpParameterValueStatus?             ScheduleValue                           { get; set; }
        public BuildUpParameterValueStatus?             SupportBonusValue                       { get; set; }

        public static BuildUpParameterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuildUpParameterStatus() { Pointer= p0 };

            value.ScheduleValue                             = GetObject<BuildUpParameterValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.BuildUpParameterValueStatus.FromPointer); // 0x18 ScheduleValue               ( ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer )
            value.SupportBonusValue                         = GetObject<BuildUpParameterValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.BuildUpParameterValueStatus.FromPointer); // 0x20 SupportBonusValue           ( ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer )

            return value;
        }
    }
}
