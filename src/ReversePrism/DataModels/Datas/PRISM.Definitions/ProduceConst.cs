using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TutorialEpisodeId                        int IL2CPP_TYPE_I4
    // 000 TutorialUnitId                           int IL2CPP_TYPE_I4
    // 000 MinStaminaRate                           int IL2CPP_TYPE_I4
    // 000 MaxStaminaRate                           int IL2CPP_TYPE_I4
    // 000 MaxUnitNameLength                        int IL2CPP_TYPE_I4
    // 000 RestScenarioIDSuffix                     string IL2CPP_TYPE_STRING
    // 000 AdviceScenarioIDSuffix                   string IL2CPP_TYPE_STRING
    // 000 SupportSkillPopupSizeUpCount             int IL2CPP_TYPE_I4
    public partial class ProduceConst : DataModel
    {

        public static ProduceConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConst() { Pointer= p0 };


            return value;
        }
    }
}
