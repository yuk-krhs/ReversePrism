using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Dic                                    Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class IDs : DataModel
    {

        public static IDs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IDs() { Pointer= p0 };


            return value;
        }
    }
}
