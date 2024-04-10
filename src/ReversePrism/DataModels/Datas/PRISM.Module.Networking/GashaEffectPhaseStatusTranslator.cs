using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class GashaEffectPhaseStatusTranslator : DataModel
    {

        public static GashaEffectPhaseStatusTranslator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaEffectPhaseStatusTranslator() { Pointer= p0 };


            return value;
        }
    }
}
