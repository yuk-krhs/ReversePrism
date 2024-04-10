using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Director                                 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    public partial class TimelineLayer : DataModel
    {
        public PlayableDirector?                        Director                                { get; set; }

        public static TimelineLayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineLayer() { Pointer= p0 };

            value.Director                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayableDirector.FromPointer); // 024664E758D8 0x20 Director                    ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )

            return value;
        }
    }
}
