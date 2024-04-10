using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 members                                  IList`1<ExtensionDataMember> IL2CPP_TYPE_GENERICINST
    public partial class ExtensionDataObject : DataModel
    {

        public static ExtensionDataObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionDataObject() { Pointer= p0 };


            return value;
        }
    }
}
