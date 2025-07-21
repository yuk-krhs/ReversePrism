using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 LessonPanel                              ModelClassType LessonPanel LessonPanel LessonPanel Pointer
    // 088 LessonModel                              ModelClassType LessonModel LessonModel LessonModel Pointer
    // 090 LessonViewModel                          ModelClassType LessonViewModel LessonViewModel LessonViewModel Pointer
    // 098 LiveScene                                ModelClassType LiveScene LiveScene LiveScene Pointer
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

            value.LessonPanel                               = GetObject<LessonPanel>(new IntPtr(p + 0x080), ReversePrism.DataModels.LessonPanel.FromPointer); // 0x80 LessonPanel                 ( ModelClassType LessonPanel LessonPanel LessonPanel Pointer )
            value.LessonModel                               = GetObject<LessonModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.LessonModel.FromPointer); // 0x88 LessonModel                 ( ModelClassType LessonModel LessonModel LessonModel Pointer )
            value.LessonViewModel                           = GetObject<LessonViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.LessonViewModel.FromPointer); // 0x90 LessonViewModel             ( ModelClassType LessonViewModel LessonViewModel LessonViewModel Pointer )
            value.LiveScene                                 = GetObject<LiveScene>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveScene.FromPointer); // 0x98 LiveScene                   ( ModelClassType LiveScene LiveScene LiveScene Pointer )

            return value;
        }
    }
}
