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
    // 018 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RivalSkillFieldNumber                    int IL2CPP_TYPE_I4
    // 020 RivalSkill                               0001866909F0 ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer
    // 000 SilhouetteIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 SilhouetteId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SilhouetteBackgroundIdFieldNumber        int IL2CPP_TYPE_I4
    // 02C SilhouetteBackgroundId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstChallengeTourRivalIdFieldNumber       int IL2CPP_TYPE_I4
    // 030 MstChallengeTourRivalId                  0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 024660EDA1A0 0x18 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.RivalSkill                                = GetObject<RivalSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RivalSkillStatus.FromPointer); // 024660EDA1E0 0x20 RivalSkill                  ( 0001866909F0 ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer )
            value.SilhouetteId                              = GetInt32(new IntPtr(p + 0x028)); // 024660EDA220 0x28 SilhouetteId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SilhouetteBackgroundId                    = GetInt32(new IntPtr(p + 0x02C)); // 024660EDA260 0x2C SilhouetteBackgroundId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstChallengeTourRivalId                   = GetInt32(new IntPtr(p + 0x030)); // 024660EDA2A0 0x30 MstChallengeTourRivalId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
