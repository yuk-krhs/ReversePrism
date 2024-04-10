using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AuditionDto                              00018650C290 ModelClassType IFinishAuditionReply IFinishAuditionReply IFinishAuditionReply Pointer
    public partial class ViewProduceResultModel : DataModel
    {
        public IFinishAuditionReply?                    AuditionDto                             { get; set; }

        public static ViewProduceResultModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProduceResultModel() { Pointer= p0 };

            value.AuditionDto                               = GetObject<IFinishAuditionReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishAuditionReply.FromPointer); // 024665C62190 0x10 AuditionDto                 ( 00018650C290 ModelClassType IFinishAuditionReply IFinishAuditionReply IFinishAuditionReply Pointer )

            return value;
        }
    }
}
