using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RivalStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstAuditionRivalIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstAuditionRivalId                       ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Parameter                                ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RivalSkillFieldNumber                    int IL2CPP_TYPE_I4
    // 028 RivalSkill                               ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer
    // 000 SilhouetteIdFieldNumber                  int IL2CPP_TYPE_I4
    // 030 SilhouetteId                             ModelPrimitiveType int int int Int32
    // 000 SilhouetteBackgroundIdFieldNumber        int IL2CPP_TYPE_I4
    // 034 SilhouetteBackgroundId                   ModelPrimitiveType int int int Int32
    public partial class RivalStatus : DataModel
    {
        public int                                      MstAuditionRivalId                      { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public RivalSkillStatus?                        RivalSkill                              { get; set; }
        public int                                      SilhouetteId                            { get; set; }
        public int                                      SilhouetteBackgroundId                  { get; set; }

        public static RivalStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RivalStatus() { Pointer= p0 };

            value.MstAuditionRivalId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstAuditionRivalId          ( ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x20 Parameter                   ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.RivalSkill                                = GetObject<RivalSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.RivalSkillStatus.FromPointer); // 0x28 RivalSkill                  ( ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer )
            value.SilhouetteId                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 SilhouetteId                ( ModelPrimitiveType int int int Int32 )
            value.SilhouetteBackgroundId                    = GetInt32(new IntPtr(p + 0x034)); // 0x34 SilhouetteBackgroundId      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
