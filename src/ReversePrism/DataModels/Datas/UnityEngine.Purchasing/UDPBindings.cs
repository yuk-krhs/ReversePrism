using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Bridge                                 <object> IL2CPP_TYPE_OBJECT
    // 018 m_RetrieveProductsCallbackCache          Action`2<bool, string> IL2CPP_TYPE_GENERICINST
    public partial class UDPBindings : DataModel
    {

        public static UDPBindings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UDPBindings() { Pointer= p0 };


            return value;
        }
    }
}
