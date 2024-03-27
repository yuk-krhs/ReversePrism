using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<OpponentStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TargetAppealPointFieldNumber             int IL2CPP_TYPE_I4
    // 018 TargetAppealPoint                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MilestoneListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_milestoneList_codec            FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MilestoneList                            000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class OpponentStatus
    {
        public int                                      TargetAppealPoint                       { get; set; }
        public List<int>?                               MilestoneList                           { get; set; }

        public static OpponentStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpponentStatus();

            value.TargetAppealPoint                         = GetInt32(new IntPtr(p + 0x018)); // 0270D10F24E8 0x18 TargetAppealPoint           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MilestoneList                             = GetInt32List(new IntPtr(p + 0x020)); // 0270D10F2548 0x20 MilestoneList               ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
