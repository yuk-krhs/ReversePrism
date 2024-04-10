using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Tracked                                Dictionary`2<Font, HashSet`1<Text>> IL2CPP_TYPE_GENERICINST
    public partial class FontUpdateTracker : DataModel
    {

        public static FontUpdateTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontUpdateTracker() { Pointer= p0 };


            return value;
        }
    }
}
