using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 168 AuditionUnitSkillExecuteTime             000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 170 Opponent                                 0001865C94D0 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    public partial class AuditionModel
    {
        public List<float>?                             AuditionUnitSkillExecuteTime            { get; set; }
        public IOpponentStatus?                         Opponent                                { get; set; }

        public static AuditionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionModel();

            value.AuditionUnitSkillExecuteTime              = GetSingleList(new IntPtr(p + 0x168)); // 0270D4CD2880 0x168 AuditionUnitSkillExecuteTime ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Opponent                                  = GetObject<IOpponentStatus>(new IntPtr(p + 0x170), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 0270D4CD28A0 0x170 Opponent                    ( 0001865C94D0 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )

            return value;
        }
    }
}
