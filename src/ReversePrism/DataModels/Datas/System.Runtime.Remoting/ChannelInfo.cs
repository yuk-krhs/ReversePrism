using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 channelData                              <object>[] IL2CPP_TYPE_SZARRAY
    public partial class ChannelInfo
    {

        public static ChannelInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelInfo();


            return value;
        }
    }
}
