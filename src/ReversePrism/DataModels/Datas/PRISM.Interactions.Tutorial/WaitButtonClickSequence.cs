using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ButtonTargetRelation                     000186518820 ModelEnumType ButtonTargetRelation ButtonTargetRelation ButtonTargetRelation Int32
    public partial class WaitButtonClickSequence
    {
        public ButtonTargetRelation                     ButtonTargetRelation                    { get; set; }

        public static WaitButtonClickSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitButtonClickSequence();

            value.ButtonTargetRelation                      = (ButtonTargetRelation)GetInt32(new IntPtr(p + 0x010)); // 0270DBC11B58 0x10 ButtonTargetRelation        ( 000186518820 ModelEnumType ButtonTargetRelation ButtonTargetRelation ButtonTargetRelation Int32 )

            return value;
        }
    }
}
