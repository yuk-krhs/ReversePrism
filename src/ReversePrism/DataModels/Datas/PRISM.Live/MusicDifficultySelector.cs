using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DifficultyToggleButtonGroup              000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 MasterDifficultyIcon                     0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 MasterDifficultyLockedIcon               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 MasterDifficultyLockedButton             000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 onSelectDifficulty                       Subject`1<SongDifficultyLevel> IL2CPP_TYPE_GENERICINST
    public partial class MusicDifficultySelector
    {
        public ToggleButtonGroup?                       DifficultyToggleButtonGroup             { get; set; }
        public Image?                                   MasterDifficultyIcon                    { get; set; }
        public Image?                                   MasterDifficultyLockedIcon              { get; set; }
        public ButtonBase?                              MasterDifficultyLockedButton            { get; set; }

        public static MusicDifficultySelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicDifficultySelector();

            value.DifficultyToggleButtonGroup               = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5159E78 0x20 DifficultyToggleButtonGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.MasterDifficultyIcon                      = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270D5159E98 0x28 MasterDifficultyIcon        ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.MasterDifficultyLockedIcon                = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270D5159EB8 0x30 MasterDifficultyLockedIcon  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.MasterDifficultyLockedButton              = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5159ED8 0x38 MasterDifficultyLockedButton ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
