using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HideOptionButton                         ModelClassType AdvMenuHideOptionButton AdvMenuHideOptionButton AdvMenuHideOptionButton Pointer
    // 028 ShowLogOptionButton                      ModelClassType AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton Pointer
    // 030 SkipOptionButton                         ModelClassType AdvMenuSkipOptionButton AdvMenuSkipOptionButton AdvMenuSkipOptionButton Pointer
    // 038 FavoriteOptionButton                     ModelClassType AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton Pointer
    // 040 AdvTextLogOverlayCaller                  ModelClassType IAdvTextLogOverlayCaller IAdvTextLogOverlayCaller IAdvTextLogOverlayCaller Pointer
    // 048 AdvSkipConfirmationPopupCaller           ModelClassType IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller Pointer
    // 050 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    public partial class AdvMenuOptionButtonContainer : DataModel
    {
        public AdvMenuHideOptionButton?                 HideOptionButton                        { get; set; }
        public AdvMenuShowLogOptionButton?              ShowLogOptionButton                     { get; set; }
        public AdvMenuSkipOptionButton?                 SkipOptionButton                        { get; set; }
        public AdvMenuFavoriteOptionButton?             FavoriteOptionButton                    { get; set; }
        public IAdvTextLogOverlayCaller?                AdvTextLogOverlayCaller                 { get; set; }
        public IAdvSkipConfirmationPopupCaller?         AdvSkipConfirmationPopupCaller          { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }

        public static AdvMenuOptionButtonContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuOptionButtonContainer() { Pointer= p0 };

            value.HideOptionButton                          = GetObject<AdvMenuHideOptionButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvMenuHideOptionButton.FromPointer); // 0x20 HideOptionButton            ( ModelClassType AdvMenuHideOptionButton AdvMenuHideOptionButton AdvMenuHideOptionButton Pointer )
            value.ShowLogOptionButton                       = GetObject<AdvMenuShowLogOptionButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvMenuShowLogOptionButton.FromPointer); // 0x28 ShowLogOptionButton         ( ModelClassType AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton AdvMenuShowLogOptionButton Pointer )
            value.SkipOptionButton                          = GetObject<AdvMenuSkipOptionButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdvMenuSkipOptionButton.FromPointer); // 0x30 SkipOptionButton            ( ModelClassType AdvMenuSkipOptionButton AdvMenuSkipOptionButton AdvMenuSkipOptionButton Pointer )
            value.FavoriteOptionButton                      = GetObject<AdvMenuFavoriteOptionButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdvMenuFavoriteOptionButton.FromPointer); // 0x38 FavoriteOptionButton        ( ModelClassType AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton AdvMenuFavoriteOptionButton Pointer )
            value.AdvTextLogOverlayCaller                   = GetObject<IAdvTextLogOverlayCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.IAdvTextLogOverlayCaller.FromPointer); // 0x40 AdvTextLogOverlayCaller     ( ModelClassType IAdvTextLogOverlayCaller IAdvTextLogOverlayCaller IAdvTextLogOverlayCaller Pointer )
            value.AdvSkipConfirmationPopupCaller            = GetObject<IAdvSkipConfirmationPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.IAdvSkipConfirmationPopupCaller.FromPointer); // 0x48 AdvSkipConfirmationPopupCaller ( ModelClassType IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller IAdvSkipConfirmationPopupCaller Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x50 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
