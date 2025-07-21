using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CloseAnimationName                       ModelPrimitiveType int int int Int32
    // 024 CloseIdleAnimationName                   ModelPrimitiveType int int int Int32
    // 028 OpenAnimationName                        ModelPrimitiveType int int int Int32
    // 02C OpenIdleAnimationName                    ModelPrimitiveType int int int Int32
    // 030 AdvMenuOptionButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 038 HideOptionButton                         ModelClassType AdvMenuHideOptionButton AdvMenuHideOptionButton AdvMenuHideOptionButton Pointer
    // 040 ShowLogOptionButton                      ModelClassType AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton Pointer
    // 048 SkipOptionButton                         ModelClassType AdvMenuSkipOptionButton AdvMenuSkipOptionButton AdvMenuSkipOptionButton Pointer
    // 050 FavoriteOptionButton                     ModelClassType AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton Pointer
    // 058 OpenMenuAnimator                         ModelClassType Animator Animator Animator Pointer
    // 060 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 068 IsMenuOpen                               ModelPrimitiveType bool bool bool Bool
    public partial class AdvMenuOptionButtonContainer : DataModel
    {
        public int                                      CloseAnimationName                      { get; set; }
        public int                                      CloseIdleAnimationName                  { get; set; }
        public int                                      OpenAnimationName                       { get; set; }
        public int                                      OpenIdleAnimationName                   { get; set; }
        public UIButton?                                AdvMenuOptionButton                     { get; set; }
        public AdvMenuHideOptionButton?                 HideOptionButton                        { get; set; }
        public AdvMenuShowLogOptionButton?              ShowLogOptionButton                     { get; set; }
        public AdvMenuSkipOptionButton?                 SkipOptionButton                        { get; set; }
        public AdvMenuFavoriteOptionButton?             FavoriteOptionButton                    { get; set; }
        public Animator?                                OpenMenuAnimator                        { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public bool                                     IsMenuOpen                              { get; set; }

        public static AdvMenuOptionButtonContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuOptionButtonContainer() { Pointer= p0 };

            value.CloseAnimationName                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 CloseAnimationName          ( ModelPrimitiveType int int int Int32 )
            value.CloseIdleAnimationName                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 CloseIdleAnimationName      ( ModelPrimitiveType int int int Int32 )
            value.OpenAnimationName                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 OpenAnimationName           ( ModelPrimitiveType int int int Int32 )
            value.OpenIdleAnimationName                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C OpenIdleAnimationName       ( ModelPrimitiveType int int int Int32 )
            value.AdvMenuOptionButton                       = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 AdvMenuOptionButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HideOptionButton                          = GetObject<AdvMenuHideOptionButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdvMenuHideOptionButton.FromPointer); // 0x38 HideOptionButton            ( ModelClassType AdvMenuHideOptionButton AdvMenuHideOptionButton AdvMenuHideOptionButton Pointer )
            value.ShowLogOptionButton                       = GetObject<AdvMenuShowLogOptionButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.AdvMenuShowLogOptionButton.FromPointer); // 0x40 ShowLogOptionButton         ( ModelClassType AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton Pointer )
            value.SkipOptionButton                          = GetObject<AdvMenuSkipOptionButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.AdvMenuSkipOptionButton.FromPointer); // 0x48 SkipOptionButton            ( ModelClassType AdvMenuSkipOptionButton AdvMenuSkipOptionButton AdvMenuSkipOptionButton Pointer )
            value.FavoriteOptionButton                      = GetObject<AdvMenuFavoriteOptionButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.AdvMenuFavoriteOptionButton.FromPointer); // 0x50 FavoriteOptionButton        ( ModelClassType AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton Pointer )
            value.OpenMenuAnimator                          = GetObject<Animator>(new IntPtr(p + 0x058), ReversePrism.DataModels.Animator.FromPointer); // 0x58 OpenMenuAnimator            ( ModelClassType Animator Animator Animator Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x60 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.IsMenuOpen                                = GetBool(new IntPtr(p + 0x068)); // 0x68 IsMenuOpen                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
