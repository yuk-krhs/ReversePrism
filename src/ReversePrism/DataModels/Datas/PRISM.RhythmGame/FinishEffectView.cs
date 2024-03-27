using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FinishAnimation                          000185B9B530 ModelClassListType PlayableDirector[] PlayableDirector[] List<PlayableDirector> Pointer
    public partial class FinishEffectView
    {
        public List<PlayableDirector>?                  FinishAnimation                         { get; set; }

        public static FinishEffectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishEffectView();

            value.FinishAnimation                           = GetObjectList<PlayableDirector>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0270D5027898 0x20 FinishAnimation             ( 000185B9B530 ModelClassListType PlayableDirector[] PlayableDirector[] List<PlayableDirector> Pointer )

            return value;
        }
    }
}
