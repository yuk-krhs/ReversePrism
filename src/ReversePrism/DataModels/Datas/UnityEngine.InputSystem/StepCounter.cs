using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 _StepCounter                             000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 000 <current>k__BackingField                 StepCounter IL2CPP_TYPE_CLASS
    public partial class StepCounter
    {
        public IntegerControl?                          _StepCounter                            { get; set; }

        public static StepCounter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepCounter();

            value._StepCounter                              = GetObject<IntegerControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.IntegerControl.FromPointer); // 0270033B2840 0x170 _StepCounter                ( 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer )

            return value;
        }
    }
}
