using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AdvMenuButton                            ModelClassType AdvMenuButton AdvMenuButton AdvMenuButton Pointer
    // 028 AdvMenuOptionButtonContainer             ModelClassType AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer Pointer
    // 030 onToggleAutoPlay                         Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 040 ResourceTag                              ModelPrimitiveType string string string String
    // 048 IsAutoPlayActive                         ModelPrimitiveType bool bool bool Bool
    // 049 IsUIActive                               ModelPrimitiveType bool bool bool Bool
    public partial class AdvMenuView : DataModel
    {
        public AdvMenuButton?                           AdvMenuButton                           { get; set; }
        public AdvMenuOptionButtonContainer?            AdvMenuOptionButtonContainer            { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public string                                   ResourceTag                             { get; set; }
        public bool                                     IsAutoPlayActive                        { get; set; }
        public bool                                     IsUIActive                              { get; set; }

        public static AdvMenuView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuView() { Pointer= p0 };

            value.AdvMenuButton                             = GetObject<AdvMenuButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvMenuButton.FromPointer); // 0x20 AdvMenuButton               ( ModelClassType AdvMenuButton AdvMenuButton AdvMenuButton Pointer )
            value.AdvMenuOptionButtonContainer              = GetObject<AdvMenuOptionButtonContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvMenuOptionButtonContainer.FromPointer); // 0x28 AdvMenuOptionButtonContainer ( ModelClassType AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer AdvMenuOptionButtonContainer Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x38 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.ResourceTag                               = GetString(new IntPtr(p + 0x040)); // 0x40 ResourceTag                 ( ModelPrimitiveType string string string String )
            value.IsAutoPlayActive                          = GetBool(new IntPtr(p + 0x048)); // 0x48 IsAutoPlayActive            ( ModelPrimitiveType bool bool bool Bool )
            value.IsUIActive                                = GetBool(new IntPtr(p + 0x049)); // 0x49 IsUIActive                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
