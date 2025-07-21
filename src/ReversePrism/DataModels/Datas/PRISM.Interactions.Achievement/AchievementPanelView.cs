using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AchievementIcons                         ModelClassListType AchievementIcon[] AchievementIcon[] List<AchievementIcon> Pointer
    // 028 onClick                                  Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 030 onLongPress                              Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 038 ClickDisposables                         ModelClassListType IDisposable[] IDisposable[] List<IDisposable> Pointer
    // 040 LongPressDisposables                     ModelClassListType IDisposable[] IDisposable[] List<IDisposable> Pointer
    public partial class AchievementPanelView : DataModel
    {
        public List<AchievementIcon>?                   AchievementIcons                        { get; set; }
        public List<IDisposable>?                       ClickDisposables                        { get; set; }
        public List<IDisposable>?                       LongPressDisposables                    { get; set; }

        public static AchievementPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementPanelView() { Pointer= p0 };

            value.AchievementIcons                          = GetObjectList<AchievementIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementIcon.FromPointer); // 0x20 AchievementIcons            ( ModelClassListType AchievementIcon[] AchievementIcon[] List<AchievementIcon> Pointer )
            value.ClickDisposables                          = GetObjectList<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0x38 ClickDisposables            ( ModelClassListType IDisposable[] IDisposable[] List<IDisposable> Pointer )
            value.LongPressDisposables                      = GetObjectList<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0x40 LongPressDisposables        ( ModelClassListType IDisposable[] IDisposable[] List<IDisposable> Pointer )

            return value;
        }
    }
}
