using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reply                                    00018650E120 ModelClassType IFinishLessonReply IFinishLessonReply IFinishLessonReply Pointer
    public partial class LegacyLessonSuccessResultParameter
    {
        public IFinishLessonReply?                      Reply                                   { get; set; }

        public static LegacyLessonSuccessResultParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyLessonSuccessResultParameter();

            value.Reply                                     = GetObject<IFinishLessonReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishLessonReply.FromPointer); // 0270D55C3BE0 0x10 Reply                       ( 00018650E120 ModelClassType IFinishLessonReply IFinishLessonReply IFinishLessonReply Pointer )

            return value;
        }
    }
}
