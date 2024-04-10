using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 played                                   Action`1<PlayableDirector> IL2CPP_TYPE_GENERICINST
    // 020 paused                                   Action`1<PlayableDirector> IL2CPP_TYPE_GENERICINST
    // 028 stopped                                  Action`1<PlayableDirector> IL2CPP_TYPE_GENERICINST
    public partial class PlayableDirector : DataModel
    {

        public static PlayableDirector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayableDirector() { Pointer= p0 };


            return value;
        }
    }
}
