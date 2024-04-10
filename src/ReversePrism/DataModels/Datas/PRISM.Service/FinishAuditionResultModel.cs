using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishAuditionResultReply           00018650CD10 ModelClassType IFinishAuditionResultReply IFinishAuditionResultReply IFinishAuditionResultReply Pointer
    public partial class FinishAuditionResultModel : DataModel
    {
        public IFinishAuditionResultReply?              CacheFinishAuditionResultReply          { get; set; }

        public static FinishAuditionResultModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishAuditionResultModel() { Pointer= p0 };

            value.CacheFinishAuditionResultReply            = GetObject<IFinishAuditionResultReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishAuditionResultReply.FromPointer); // 024666614D78 0x10 CacheFinishAuditionResultReply ( 00018650CD10 ModelClassType IFinishAuditionResultReply IFinishAuditionResultReply IFinishAuditionResultReply Pointer )

            return value;
        }
    }
}
