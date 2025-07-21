using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourRivalStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 018 Parameter                                ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RivalSkillFieldNumber                    int IL2CPP_TYPE_I4
    // 020 RivalSkill                               ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer
    // 000 SilhouetteIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 SilhouetteId                             ModelPrimitiveType int int int Int32
    // 000 SilhouetteBackgroundIdFieldNumber        int IL2CPP_TYPE_I4
    // 02C SilhouetteBackgroundId                   ModelPrimitiveType int int int Int32
    // 000 MstChallengeTourRivalIdFieldNumber       int IL2CPP_TYPE_I4
    // 030 MstChallengeTourRivalId                  ModelPrimitiveType int int int Int32
    public partial class ChallengeTourRivalStatus : DataModel
    {
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public RivalSkillStatus?                        RivalSkill                              { get; set; }
        public int                                      SilhouetteId                            { get; set; }
        public int                                      SilhouetteBackgroundId                  { get; set; }
        public int                                      MstChallengeTourRivalId                 { get; set; }

        public static ChallengeTourRivalStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourRivalStatus() { Pointer= p0 };

            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x18 Parameter                   ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.RivalSkill                                = GetObject<RivalSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RivalSkillStatus.FromPointer); // 0x20 RivalSkill                  ( ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer )
            value.SilhouetteId                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 SilhouetteId                ( ModelPrimitiveType int int int Int32 )
            value.SilhouetteBackgroundId                    = GetInt32(new IntPtr(p + 0x02C)); // 0x2C SilhouetteBackgroundId      ( ModelPrimitiveType int int int Int32 )
            value.MstChallengeTourRivalId                   = GetInt32(new IntPtr(p + 0x030)); // 0x30 MstChallengeTourRivalId     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
