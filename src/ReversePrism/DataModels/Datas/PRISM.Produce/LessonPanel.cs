using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0D0 LessonTitle                              ModelClassType LessonTitleContent LessonTitleContent LessonTitleContent Pointer
    public partial class LessonPanel : DataModel
    {
        public LessonTitleContent?                      LessonTitle                             { get; set; }

        public static LessonPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonPanel() { Pointer= p0 };

            value.LessonTitle                               = GetObject<LessonTitleContent>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.LessonTitleContent.FromPointer); // 0xD0 LessonTitle                 ( ModelClassType LessonTitleContent LessonTitleContent LessonTitleContent Pointer )

            return value;
        }
    }
}
