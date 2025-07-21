using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdvChoiceButtonGroupViewModel            ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer
    // 018 AdvScenarioInfo                          ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 020 AdvUI                                    ModelClassType ADVUI ADVUI ADVUI Pointer
    public partial class ADVUIInitializer : DataModel
    {
        public AdvChoiceButtonGroupViewModel?           AdvChoiceButtonGroupViewModel           { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public ADVUI?                                   AdvUI                                   { get; set; }

        public static ADVUIInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVUIInitializer() { Pointer= p0 };

            value.AdvChoiceButtonGroupViewModel             = GetObject<AdvChoiceButtonGroupViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvChoiceButtonGroupViewModel.FromPointer); // 0x10 AdvChoiceButtonGroupViewModel ( ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 0x18 AdvScenarioInfo             ( ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.AdvUI                                     = GetObject<ADVUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.ADVUI.FromPointer); // 0x20 AdvUI                       ( ModelClassType ADVUI ADVUI ADVUI Pointer )

            return value;
        }
    }
}
