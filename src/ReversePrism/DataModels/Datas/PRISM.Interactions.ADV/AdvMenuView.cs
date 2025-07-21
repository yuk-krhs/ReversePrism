using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AdvMenuOptionButtonContainer             ModelClassType AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer Pointer
    // 028 AdvMenuFader                             ModelClassType AdvMenuFader AdvMenuFader AdvMenuFader Pointer
    // 030 AdvForceSkipButton                       ModelClassType AdvForceSkipButton AdvForceSkipButton AdvForceSkipButton Pointer
    // 038 onToggleAutoPlay                         Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 048 IsAutoPlayActive                         ModelPrimitiveType bool bool bool Bool
    // 049 IsUIActive                               ModelPrimitiveType bool bool bool Bool
    public partial class AdvMenuView : DataModel
    {
        public AdvMenuOptionButtonContainer?            AdvMenuOptionButtonContainer            { get; set; }
        public AdvMenuFader?                            AdvMenuFader                            { get; set; }
        public AdvForceSkipButton?                      AdvForceSkipButton                      { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public bool                                     IsAutoPlayActive                        { get; set; }
        public bool                                     IsUIActive                              { get; set; }

        public static AdvMenuView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuView() { Pointer= p0 };

            value.AdvMenuOptionButtonContainer              = GetObject<AdvMenuOptionButtonContainer>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvMenuOptionButtonContainer.FromPointer); // 0x20 AdvMenuOptionButtonContainer ( ModelClassType AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer Pointer )
            value.AdvMenuFader                              = GetObject<AdvMenuFader>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvMenuFader.FromPointer); // 0x28 AdvMenuFader                ( ModelClassType AdvMenuFader AdvMenuFader AdvMenuFader Pointer )
            value.AdvForceSkipButton                        = GetObject<AdvForceSkipButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdvForceSkipButton.FromPointer); // 0x30 AdvForceSkipButton          ( ModelClassType AdvForceSkipButton AdvForceSkipButton AdvForceSkipButton Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x40 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.IsAutoPlayActive                          = GetBool(new IntPtr(p + 0x048)); // 0x48 IsAutoPlayActive            ( ModelPrimitiveType bool bool bool Bool )
            value.IsUIActive                                = GetBool(new IntPtr(p + 0x049)); // 0x49 IsUIActive                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
