using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 168 EnemySkillExecuteTime                    000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 170 EventEffect                              0001866053B0 ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer
    public partial class PvpInGameModel
    {
        public List<float>?                             EnemySkillExecuteTime                   { get; set; }
        public IPvpEventEffectStatus?                   EventEffect                             { get; set; }

        public static PvpInGameModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameModel();

            value.EnemySkillExecuteTime                     = GetSingleList(new IntPtr(p + 0x168)); // 0270D5077198 0x168 EnemySkillExecuteTime       ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.EventEffect                               = GetObject<IPvpEventEffectStatus>(new IntPtr(p + 0x170), ReversePrism.DataModels.IPvpEventEffectStatus.FromPointer); // 0270D50771B8 0x170 EventEffect                 ( 0001866053B0 ModelClassType IPvpEventEffectStatus IPvpEventEffectStatus IPvpEventEffectStatus Pointer )

            return value;
        }
    }
}
