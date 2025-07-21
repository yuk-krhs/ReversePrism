using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AchievementIcon                          ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer
    // 038 SettingsObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 040 SelectedDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    // 048 SettingsDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProfileAchievementSelectGridViewCell : DataModel
    {
        public AchievementIcon?                         AchievementIcon                         { get; set; }
        public GameObject?                              SettingsObject                          { get; set; }
        public IDisposable?                             SelectedDisposable                      { get; set; }
        public IDisposable?                             SettingsDisposable                      { get; set; }

        public static ProfileAchievementSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSelectGridViewCell() { Pointer= p0 };

            value.AchievementIcon                           = GetObject<AchievementIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.AchievementIcon.FromPointer); // 0x30 AchievementIcon             ( ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer )
            value.SettingsObject                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SettingsObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0x40 SelectedDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SettingsDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 SettingsDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
