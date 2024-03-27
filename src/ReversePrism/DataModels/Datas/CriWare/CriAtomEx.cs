using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvalidAisacControlId                    uint IL2CPP_TYPE_U4
    // 000 randomize3dParamTable                    Dictionary`2<Randomize3dCalcType, Randomize3dParamType[]> IL2CPP_TYPE_GENERICINST
    public partial class CriAtomEx
    {

        public static CriAtomEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomEx();


            return value;
        }
    }
}
