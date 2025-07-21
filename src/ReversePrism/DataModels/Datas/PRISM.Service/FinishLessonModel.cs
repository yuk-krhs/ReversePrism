using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishLessonReply                   ModelClassType IFinishLessonReply IFinishLessonReply IFinishLessonReply Pointer
    public partial class FinishLessonModel : DataModel
    {
        public IFinishLessonReply?                      CacheFinishLessonReply                  { get; set; }

        public static FinishLessonModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishLessonModel() { Pointer= p0 };

            value.CacheFinishLessonReply                    = GetObject<IFinishLessonReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishLessonReply.FromPointer); // 0x10 CacheFinishLessonReply      ( ModelClassType IFinishLessonReply IFinishLessonReply IFinishLessonReply Pointer )

            return value;
        }
    }
}
