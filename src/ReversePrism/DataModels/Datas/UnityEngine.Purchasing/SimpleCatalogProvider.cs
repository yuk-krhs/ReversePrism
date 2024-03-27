using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Func                                   Action`1<Action`1<HashSet`1<ProductDefinition>>> IL2CPP_TYPE_GENERICINST
    public partial class SimpleCatalogProvider
    {

        public static SimpleCatalogProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleCatalogProvider();


            return value;
        }
    }
}
