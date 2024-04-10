using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HpThresholdValue                         float IL2CPP_TYPE_R4
    // 000 InitialHandCount                         int IL2CPP_TYPE_I4
    // 000 DefaultPhase                             int IL2CPP_TYPE_I4
    // 000 HandCountMaxLimit                        int IL2CPP_TYPE_I4
    // 000 MentalGuardLimit                         int IL2CPP_TYPE_I4
    // 000 MentalFewRate                            int IL2CPP_TYPE_I4
    // 000 MentalPinchRate                          int IL2CPP_TYPE_I4
    // 000 MentalSafeHigh                           int IL2CPP_TYPE_I4
    // 000 MentalSafeMiddle                         int IL2CPP_TYPE_I4
    // 000 MentalSafeLow                            int IL2CPP_TYPE_I4
    // 000 TypeCounterMax                           int IL2CPP_TYPE_I4
    // 000 MaxProducePointValue                     int IL2CPP_TYPE_I4
    // 000 ShhisUnitId                              int IL2CPP_TYPE_I4
    // 000 AiLogicNum                               int IL2CPP_TYPE_I4
    public partial class InGameDefine : DataModel
    {

        public static InGameDefine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameDefine() { Pointer= p0 };


            return value;
        }
    }
}
