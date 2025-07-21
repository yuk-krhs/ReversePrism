using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_LayerBatches                           LayerBatch[] IL2CPP_TYPE_SZARRAY
    // 008 <maxTextureCount>k__BackingField         uint IL2CPP_TYPE_U4
    public partial class LayerUtility : DataModel
    {

        public static LayerUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayerUtility() { Pointer= p0 };


            return value;
        }
    }
}
