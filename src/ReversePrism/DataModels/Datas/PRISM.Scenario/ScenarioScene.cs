using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IsStartEnd                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 IsBeforeInitialize                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 Canvas                                   00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 038 AdvUI                                    000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer
    // 040 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 048 Fader                                    0001866E6F00 ModelClassType UIFader UIFader UIFader Pointer
    // 050 Parameter                                000186523990 ModelClassType ViewScenarioParameter ViewScenarioParameter ViewScenarioParameter Pointer
    public partial class ScenarioScene : DataModel
    {
        public bool                                     IsStartEnd                              { get; set; }
        public bool                                     IsBeforeInitialize                      { get; set; }
        public Canvas?                                  Canvas                                  { get; set; }
        public ADVUI?                                   AdvUI                                   { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public UIFader?                                 Fader                                   { get; set; }
        public ViewScenarioParameter?                   Parameter                               { get; set; }

        public static ScenarioScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioScene() { Pointer= p0 };

            value.IsStartEnd                                = GetBool(new IntPtr(p + 0x028)); // 024665E67D28 0x28 IsStartEnd                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsBeforeInitialize                        = GetBool(new IntPtr(p + 0x029)); // 024665E67D48 0x29 IsBeforeInitialize          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Canvas                                    = GetObject<Canvas>(new IntPtr(p + 0x030), ReversePrism.DataModels.Canvas.FromPointer); // 024665E67D68 0x30 Canvas                      ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.AdvUI                                     = GetObject<ADVUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.ADVUI.FromPointer); // 024665E67D88 0x38 AdvUI                       ( 000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScenarioManager.FromPointer); // 024665E67DA8 0x40 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Fader                                     = GetObject<UIFader>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIFader.FromPointer); // 024665E67DC8 0x48 Fader                       ( 0001866E6F00 ModelClassType UIFader UIFader UIFader Pointer )
            value.Parameter                                 = GetObject<ViewScenarioParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ViewScenarioParameter.FromPointer); // 024665E67DE8 0x50 Parameter                   ( 000186523990 ModelClassType ViewScenarioParameter ViewScenarioParameter ViewScenarioParameter Pointer )

            return value;
        }
    }
}
