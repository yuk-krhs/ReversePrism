using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 selectedToggleIndices                    HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 018 onSelectedToggleIndicesReset             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class StorySortFilterToggleFilterViewModel : DataModel
    {

        public static StorySortFilterToggleFilterViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterToggleFilterViewModel() { Pointer= p0 };


            return value;
        }
    }
}
