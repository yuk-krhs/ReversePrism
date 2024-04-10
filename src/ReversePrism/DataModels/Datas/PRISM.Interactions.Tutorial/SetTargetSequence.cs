using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class SetTargetSequence : DataModel
    {
        public RectTransform?                           Target                                  { get; set; }

        public static SetTargetSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetTargetSequence() { Pointer= p0 };

            value.Target                                    = GetObject<RectTransform>(new IntPtr(p + 0x010), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A57430F8 0x10 Target                      ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
