using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Entries                                List`1<MatEntry> IL2CPP_TYPE_GENERICINST
    public partial class ModifiedMaterial
    {

        public static ModifiedMaterial? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModifiedMaterial();


            return value;
        }
    }
}
