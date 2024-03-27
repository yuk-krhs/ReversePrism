using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reply                                    0001865145F0 ModelClassType IFinishSpecialLessonReply IFinishSpecialLessonReply IFinishSpecialLessonReply Pointer
    public partial class LegacySpecialLessonResultParameter
    {
        public IFinishSpecialLessonReply?               Reply                                   { get; set; }

        public static LegacySpecialLessonResultParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacySpecialLessonResultParameter();

            value.Reply                                     = GetObject<IFinishSpecialLessonReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishSpecialLessonReply.FromPointer); // 0270D55C82F0 0x10 Reply                       ( 0001865145F0 ModelClassType IFinishSpecialLessonReply IFinishSpecialLessonReply IFinishSpecialLessonReply Pointer )

            return value;
        }
    }
}
