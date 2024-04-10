using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPotentialLiveSkillIdFieldNumber       int IL2CPP_TYPE_I4
    // 018 MstPotentialLiveSkillId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LevelListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_levelList_codec                FieldCodec`1<PotentialLiveSkillLevelStatus> IL2CPP_TYPE_GENERICINST
    // 020 LevelList                                000185CE8ED8 ModelClassListType RepeatedField`1<PotentialLiveSkillLevelStatus> RepeatedField`1<PotentialLiveSkillLevelStatus> List<PotentialLiveSkillLevelStatus> Pointer
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Level                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 UnlockPremiseStarFieldNumber             int IL2CPP_TYPE_I4
    // 030 UnlockPremiseStar                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PotentialLiveSkillStatus : DataModel
    {
        public int                                      MstPotentialLiveSkillId                 { get; set; }
        public List<PotentialLiveSkillLevelStatus>?     LevelList                               { get; set; }
        public LimitedValueStatus?                      Level                                   { get; set; }
        public int                                      UnlockPremiseStar                       { get; set; }

        public static PotentialLiveSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialLiveSkillStatus() { Pointer= p0 };

            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x018)); // 024660FC4D80 0x18 MstPotentialLiveSkillId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LevelList                                 = GetObjectList<PotentialLiveSkillLevelStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.PotentialLiveSkillLevelStatus.FromPointer); // 024660FC4DE0 0x20 LevelList                   ( 000185CE8ED8 ModelClassListType RepeatedField`1<PotentialLiveSkillLevelStatus> RepeatedField`1<PotentialLiveSkillLevelStatus> List<PotentialLiveSkillLevelStatus> Pointer )
            value.Level                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024660FC4E20 0x28 Level                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.UnlockPremiseStar                         = GetInt32(new IntPtr(p + 0x030)); // 024660FC4E60 0x30 UnlockPremiseStar           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
