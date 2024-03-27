using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Hazuki                                   int IL2CPP_TYPE_I4
    // 000 FesIdolLimit                             int IL2CPP_TYPE_I4
    // 000 FesIdolTransferLimit                     int IL2CPP_TYPE_I4
    // 000 FesUnitLimit                             int IL2CPP_TYPE_I4
    // 000 FesUnitTransferLimit                     int IL2CPP_TYPE_I4
    // 000 MaxUnitMemberCount                       int IL2CPP_TYPE_I4
    // 000 LiveUnitMaxCount                         int IL2CPP_TYPE_I4
    // 000 UnitNameMaxLength                        int IL2CPP_TYPE_I4
    // 000 MaxPieceSelectedNum                      int IL2CPP_TYPE_I4
    // 000 PieceChangeRate                          int IL2CPP_TYPE_I4
    // 000 SupportEffectFilterSchedule              Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 008 SupportEffectFilterScheduleDetail        Dictionary`2<int, HashSet`1<int>> IL2CPP_TYPE_GENERICINST
    // 010 ProducePassiveEffectTypeIdNotRefersToSchedule HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 018 ProducePassiveEffectTypeIdRefersToScheduleDetail HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 020 ProducePassiveEffectTypeIdRefersToSchedule HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 028 ScheduleDetailTypeBelongingToScheduleType Dictionary`2<int, HashSet`1<int>> IL2CPP_TYPE_GENERICINST
    // 000 RequiredItemsNumByGroup                  int IL2CPP_TYPE_I4
    // 000 FUnitLabelBlinkDuration                  float IL2CPP_TYPE_R4
    // 000 TrainingTicketConsumptionMoneyFactor     float IL2CPP_TYPE_R4
    // 000 ProducerCharacterId                      int IL2CPP_TYPE_I4
    // 000 HazukiBirthdayCueName                    string IL2CPP_TYPE_STRING
    // 000 GalleryEtcImageWidth                     float IL2CPP_TYPE_R4
    // 000 FixedBonusNum                            int IL2CPP_TYPE_I4
    // 000 AdditionalBonusNum                       int IL2CPP_TYPE_I4
    public partial class CharacterConst
    {

        public static CharacterConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterConst();


            return value;
        }
    }
}
