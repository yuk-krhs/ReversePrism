using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FinishAnimation                          ModelClassListType PlayableDirector[] PlayableDirector[] List<PlayableDirector> Pointer
    public partial class FinishEffectView : DataModel
    {
        public List<PlayableDirector>?                  FinishAnimation                         { get; set; }

        public static FinishEffectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishEffectView() { Pointer= p0 };

            value.FinishAnimation                           = GetObjectList<PlayableDirector>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x20 FinishAnimation             ( ModelClassListType PlayableDirector[] PlayableDirector[] List<PlayableDirector> Pointer )

            return value;
        }
    }
}
