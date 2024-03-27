using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reply                                    00018650C590 ModelClassType IFinishAuditionReply IFinishAuditionReply IFinishAuditionReply Pointer
    public partial class LegacyAuditionSuccessResultParameter
    {
        public IFinishAuditionReply?                    Reply                                   { get; set; }

        public static LegacyAuditionSuccessResultParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyAuditionSuccessResultParameter();

            value.Reply                                     = GetObject<IFinishAuditionReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishAuditionReply.FromPointer); // 0270D55BEB70 0x10 Reply                       ( 00018650C590 ModelClassType IFinishAuditionReply IFinishAuditionReply IFinishAuditionReply Pointer )

            return value;
        }
    }
}
