using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 158 EnemySkillExecuteTime                    ModelPrimitiveListType float[] float[] List<float> Pointer
    // 160 EventEffect                              ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer
    public partial class PvpInGameModel : DataModel
    {
        public List<float>?                             EnemySkillExecuteTime                   { get; set; }
        public IPvpEventEffectStatus?                   EventEffect                             { get; set; }

        public static PvpInGameModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameModel() { Pointer= p0 };

            value.EnemySkillExecuteTime                     = GetSingleList(new IntPtr(p + 0x158)); // 0x158 EnemySkillExecuteTime       ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.EventEffect                               = GetObject<IPvpEventEffectStatus>(new IntPtr(p + 0x160), ReversePrism.DataModels.IPvpEventEffectStatus.FromPointer); // 0x160 EventEffect                 ( ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer )

            return value;
        }
    }
}
