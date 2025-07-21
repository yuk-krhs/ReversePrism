using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DetermineProduceResultArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 018 MstFavoriteMarkId                        ModelPrimitiveType int int int Int32
    // 000 AttachingPotentialLiveSkillListFieldNumber int IL2CPP_TYPE_I4
    // 008 _repeated_attachingPotentialLiveSkillList_codec FieldCodec`1<AttachingPotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 020 AttachingPotentialLiveSkillList          ModelClassListType RepeatedField`1<AttachingPotentialLiveSkillStatus> RepeatedField`1<AttachingPotentialLiveSkillStatus> List<AttachingPotentialLiveSkillStatus> Pointer
    public partial class DetermineProduceResultArgs : DataModel
    {
        public int                                      MstFavoriteMarkId                       { get; set; }
        public List<AttachingPotentialLiveSkillStatus>? AttachingPotentialLiveSkillList         { get; set; }

        public static DetermineProduceResultArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DetermineProduceResultArgs() { Pointer= p0 };

            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstFavoriteMarkId           ( ModelPrimitiveType int int int Int32 )
            value.AttachingPotentialLiveSkillList           = GetObjectList<AttachingPotentialLiveSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.AttachingPotentialLiveSkillStatus.FromPointer); // 0x20 AttachingPotentialLiveSkillList ( ModelClassListType RepeatedField`1<AttachingPotentialLiveSkillStatus> RepeatedField`1<AttachingPotentialLiveSkillStatus> List<AttachingPotentialLiveSkillStatus> Pointer )

            return value;
        }
    }
}
