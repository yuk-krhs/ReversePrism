using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartAuditionReply                  00018664E410 ModelClassType IStartAuditionReply IStartAuditionReply IStartAuditionReply Pointer
    public partial class StartAuditionModel : DataModel
    {
        public IStartAuditionReply?                     CacheStartAuditionReply                 { get; set; }

        public static StartAuditionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartAuditionModel() { Pointer= p0 };

            value.CacheStartAuditionReply                   = GetObject<IStartAuditionReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartAuditionReply.FromPointer); // 024666635C08 0x10 CacheStartAuditionReply     ( 00018664E410 ModelClassType IStartAuditionReply IStartAuditionReply IStartAuditionReply Pointer )

            return value;
        }
    }
}
