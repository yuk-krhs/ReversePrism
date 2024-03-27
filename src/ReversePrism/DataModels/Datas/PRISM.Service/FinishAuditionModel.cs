using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishAuditionReply                 00018650C290 ModelClassType IFinishAuditionReply IFinishAuditionReply IFinishAuditionReply Pointer
    public partial class FinishAuditionModel
    {
        public IFinishAuditionReply?                    CacheFinishAuditionReply                { get; set; }

        public static FinishAuditionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishAuditionModel();

            value.CacheFinishAuditionReply                  = GetObject<IFinishAuditionReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishAuditionReply.FromPointer); // 0270D65ACD60 0x10 CacheFinishAuditionReply    ( 00018650C290 ModelClassType IFinishAuditionReply IFinishAuditionReply IFinishAuditionReply Pointer )

            return value;
        }
    }
}
