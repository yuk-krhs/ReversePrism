using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LoginBonusSheetStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NumFieldNumber                           int IL2CPP_TYPE_I4
    // 018 Num                                      ModelPrimitiveType int int int Int32
    // 000 StepListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_stepList_codec                 FieldCodec`1<LoginBonusStepStatus> IL2CPP_TYPE_GENERICINST
    // 020 StepList                                 ModelClassListType RepeatedField`1<LoginBonusStepStatus> RepeatedField`1<LoginBonusStepStatus> List<LoginBonusStepStatus> Pointer
    public partial class LoginBonusSheetStatus : DataModel
    {
        public int                                      Num                                     { get; set; }
        public List<LoginBonusStepStatus>?              StepList                                { get; set; }

        public static LoginBonusSheetStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusSheetStatus() { Pointer= p0 };

            value.Num                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Num                         ( ModelPrimitiveType int int int Int32 )
            value.StepList                                  = GetObjectList<LoginBonusStepStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LoginBonusStepStatus.FromPointer); // 0x20 StepList                    ( ModelClassListType RepeatedField`1<LoginBonusStepStatus> RepeatedField`1<LoginBonusStepStatus> List<LoginBonusStepStatus> Pointer )

            return value;
        }
    }
}
