using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StepViews                                000185B81D20 ModelClassListType GashaStepView[] GashaStepView[] List<GashaStepView> Pointer
    public partial class GashaStepListView : DataModel
    {
        public List<GashaStepView>?                     StepViews                               { get; set; }

        public static GashaStepListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaStepListView() { Pointer= p0 };

            value.StepViews                                 = GetObjectList<GashaStepView>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaStepView.FromPointer); // 024665449388 0x20 StepViews                   ( 000185B81D20 ModelClassListType GashaStepView[] GashaStepView[] List<GashaStepView> Pointer )

            return value;
        }
    }
}
