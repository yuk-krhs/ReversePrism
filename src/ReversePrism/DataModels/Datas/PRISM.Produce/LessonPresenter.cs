using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 LessonPanel                              00018651DBE0 ModelClassType LessonPanel LessonPanel LessonPanel Pointer
    // 078 LessonModel                              00018651D440 ModelClassType LessonModel LessonModel LessonModel Pointer
    // 080 LessonViewModel                          000186520790 ModelClassType LessonViewModel LessonViewModel LessonViewModel Pointer
    // 088 LiveScene                                0001865771C0 ModelClassType LiveScene LiveScene LiveScene Pointer
    public partial class LessonPresenter : DataModel
    {
        public LessonPanel?                             LessonPanel                             { get; set; }
        public LessonModel?                             LessonModel                             { get; set; }
        public LessonViewModel?                         LessonViewModel                         { get; set; }
        public LiveScene?                               LiveScene                               { get; set; }

        public static LessonPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonPresenter() { Pointer= p0 };

            value.LessonPanel                               = GetObject<LessonPanel>(new IntPtr(p + 0x070), ReversePrism.DataModels.LessonPanel.FromPointer); // 024665C629D0 0x70 LessonPanel                 ( 00018651DBE0 ModelClassType LessonPanel LessonPanel LessonPanel Pointer )
            value.LessonModel                               = GetObject<LessonModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.LessonModel.FromPointer); // 024665C629F0 0x78 LessonModel                 ( 00018651D440 ModelClassType LessonModel LessonModel LessonModel Pointer )
            value.LessonViewModel                           = GetObject<LessonViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.LessonViewModel.FromPointer); // 024665C62A10 0x80 LessonViewModel             ( 000186520790 ModelClassType LessonViewModel LessonViewModel LessonViewModel Pointer )
            value.LiveScene                                 = GetObject<LiveScene>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveScene.FromPointer); // 024665C62A30 0x88 LiveScene                   ( 0001865771C0 ModelClassType LiveScene LiveScene LiveScene Pointer )

            return value;
        }
    }
}
