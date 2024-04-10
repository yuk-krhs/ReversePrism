using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NestedTweenFailureBehaviour              000186698930 ModelEnumType NestedTweenFailureBehaviour NestedTweenFailureBehaviour NestedTweenFailureBehaviour Int32
    public partial class SafeModeOptions : DataModel
    {
        public NestedTweenFailureBehaviour              NestedTweenFailureBehaviour             { get; set; }

        public static SafeModeOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeModeOptions() { Pointer= p0 };

            value.NestedTweenFailureBehaviour               = (NestedTweenFailureBehaviour)GetInt32(new IntPtr(p + 0x010)); // 0245A43A95A8 0x10 NestedTweenFailureBehaviour ( 000186698930 ModelEnumType NestedTweenFailureBehaviour NestedTweenFailureBehaviour NestedTweenFailureBehaviour Int32 )

            return value;
        }
    }
}
