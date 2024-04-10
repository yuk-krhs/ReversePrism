using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Instance>k__BackingField                ProduceInGamePool IL2CPP_TYPE_CLASS
    // 010 <EffectGroupPool>k__BackingField         ObjectPool`1<ProduceInGameEffectGroup> IL2CPP_TYPE_GENERICINST
    // 018 <EffectPool>k__BackingField              ObjectPool`1<ProduceInGameEffect> IL2CPP_TYPE_GENERICINST
    // 020 <SkillPool>k__BackingField               ObjectPool`1<SkillData> IL2CPP_TYPE_GENERICINST
    // 028 <TemporaryEffectListPool>k__BackingField ObjectPool`1<List`1<ProduceInGameEffect>> IL2CPP_TYPE_GENERICINST
    // 030 <InGameActionResultPool>k__BackingField  ObjectPool`1<InGameActionResult> IL2CPP_TYPE_GENERICINST
    // 038 <InGamePlayerActionResultPool>k__BackingField ObjectPool`1<InGamePlayerActionResult> IL2CPP_TYPE_GENERICINST
    // 040 <TemporaryCardListPool>k__BackingField   ObjectPool`1<List`1<IngamePCardModel>> IL2CPP_TYPE_GENERICINST
    public partial class ProduceInGamePool : DataModel
    {

        public static ProduceInGamePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePool() { Pointer= p0 };


            return value;
        }
    }
}
