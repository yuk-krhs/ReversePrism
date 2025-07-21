using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 158 AuditionUnitSkillExecuteTime             ModelPrimitiveListType float[] float[] List<float> Pointer
    // 160 Opponent                                 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    public partial class AuditionModel : DataModel
    {
        public List<float>?                             AuditionUnitSkillExecuteTime            { get; set; }
        public IOpponentStatus?                         Opponent                                { get; set; }

        public static AuditionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionModel() { Pointer= p0 };

            value.AuditionUnitSkillExecuteTime              = GetSingleList(new IntPtr(p + 0x158)); // 0x158 AuditionUnitSkillExecuteTime ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Opponent                                  = GetObject<IOpponentStatus>(new IntPtr(p + 0x160), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 0x160 Opponent                    ( ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )

            return value;
        }
    }
}
