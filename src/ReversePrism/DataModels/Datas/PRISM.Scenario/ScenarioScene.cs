using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IsStartEnd                               ModelPrimitiveType bool bool bool Bool
    // 029 IsBeforeInitialize                       ModelPrimitiveType bool bool bool Bool
    // 030 Canvas                                   ModelClassType Canvas Canvas Canvas Pointer
    // 038 AdvScreenBuilder                         ModelClassType AdvScreenBuilderForLegacy AdvScreenBuilderForLegacy AdvScreenBuilderForLegacy Pointer
    // 040 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 048 Fader                                    ModelClassType UIFader UIFader UIFader Pointer
    // 050 Parameter                                ModelClassType AdvLauncherParameter AdvLauncherParameter AdvLauncherParameter Pointer
    public partial class ScenarioScene : DataModel
    {
        public bool                                     IsStartEnd                              { get; set; }
        public bool                                     IsBeforeInitialize                      { get; set; }
        public Canvas?                                  Canvas                                  { get; set; }
        public AdvScreenBuilderForLegacy?               AdvScreenBuilder                        { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public UIFader?                                 Fader                                   { get; set; }
        public AdvLauncherParameter?                    Parameter                               { get; set; }

        public static ScenarioScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioScene() { Pointer= p0 };

            value.IsStartEnd                                = GetBool(new IntPtr(p + 0x028)); // 0x28 IsStartEnd                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsBeforeInitialize                        = GetBool(new IntPtr(p + 0x029)); // 0x29 IsBeforeInitialize          ( ModelPrimitiveType bool bool bool Bool )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x030), ReversePrism.DataModels.Canvas.FromPointer); // 0x30 Canvas                      ( ModelClassType Canvas Canvas Canvas Pointer )
            value.AdvScreenBuilder                          = GetObject<AdvScreenBuilderForLegacy>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdvScreenBuilderForLegacy.FromPointer); // 0x38 AdvScreenBuilder            ( ModelClassType AdvScreenBuilderForLegacy AdvScreenBuilderForLegacy AdvScreenBuilderForLegacy Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x40 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Fader                                     = GetObject<UIFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIFader.FromPointer); // 0x48 Fader                       ( ModelClassType UIFader UIFader UIFader Pointer )
            value.Parameter                                 = GetObject<AdvLauncherParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.AdvLauncherParameter.FromPointer); // 0x50 Parameter                   ( ModelClassType AdvLauncherParameter AdvLauncherParameter AdvLauncherParameter Pointer )

            return value;
        }
    }
}
