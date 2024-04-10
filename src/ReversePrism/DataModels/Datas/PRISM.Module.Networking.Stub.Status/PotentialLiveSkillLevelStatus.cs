using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PotentialLiveSkillLevelStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Level                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseStarFieldNumber             int IL2CPP_TYPE_I4
    // 01C UnlockPremiseStar                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstPotentialLiveSkillLevelIdFieldNumber  int IL2CPP_TYPE_I4
    // 020 MstPotentialLiveSkillLevelId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_parameterList_codec            FieldCodec`1<PotentialLiveSkillParameterStatus> IL2CPP_TYPE_GENERICINST
    // 028 ParameterList                            000185CE9128 ModelClassListType RepeatedField`1<PotentialLiveSkillParameterStatus> RepeatedField`1<PotentialLiveSkillParameterStatus> List<PotentialLiveSkillParameterStatus> Pointer
    public partial class PotentialLiveSkillLevelStatus : DataModel
    {
        public int                                      Level                                   { get; set; }
        public int                                      UnlockPremiseStar                       { get; set; }
        public int                                      MstPotentialLiveSkillLevelId            { get; set; }
        public List<PotentialLiveSkillParameterStatus>? ParameterList                           { get; set; }

        public static PotentialLiveSkillLevelStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialLiveSkillLevelStatus() { Pointer= p0 };

            value.Level                                     = GetInt32(new IntPtr(p + 0x018)); // 024660FBC020 0x18 Level                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseStar                         = GetInt32(new IntPtr(p + 0x01C)); // 024660FBC060 0x1C UnlockPremiseStar           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillLevelId              = GetInt32(new IntPtr(p + 0x020)); // 024660FBC0A0 0x20 MstPotentialLiveSkillLevelId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParameterList                             = GetObjectList<PotentialLiveSkillParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PotentialLiveSkillParameterStatus.FromPointer); // 024660FBC100 0x28 ParameterList               ( 000185CE9128 ModelClassListType RepeatedField`1<PotentialLiveSkillParameterStatus> RepeatedField`1<PotentialLiveSkillParameterStatus> List<PotentialLiveSkillParameterStatus> Pointer )

            return value;
        }
    }
}
