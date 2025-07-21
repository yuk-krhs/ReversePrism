using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdvScenarioInfo                          ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 018 AdvChoiceButtonGroupViewModel            ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer
    public partial class AdvScreenViewModel : DataModel
    {
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public AdvChoiceButtonGroupViewModel?           AdvChoiceButtonGroupViewModel           { get; set; }

        public static AdvScreenViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvScreenViewModel() { Pointer= p0 };

            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 0x10 AdvScenarioInfo             ( ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.AdvChoiceButtonGroupViewModel             = GetObject<AdvChoiceButtonGroupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.AdvChoiceButtonGroupViewModel.FromPointer); // 0x18 AdvChoiceButtonGroupViewModel ( ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer )

            return value;
        }
    }
}
