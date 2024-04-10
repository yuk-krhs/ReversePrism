using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <AdvChoiceButtonViewModels>k__BackingField IReadOnlyDictionary`2<int, AdvChoiceButtonViewModel> IL2CPP_TYPE_GENERICINST
    // 018 <OnChoiceSelectedAsyncFunc>k__BackingField Func`3<int, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    public partial class AdvChoiceButtonGroupViewModel : DataModel
    {

        public static AdvChoiceButtonGroupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvChoiceButtonGroupViewModel() { Pointer= p0 };


            return value;
        }
    }
}
