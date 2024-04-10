using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <enabled>k__BackingField                 bool IL2CPP_TYPE_BOOLEAN
    // 001 running                                  bool IL2CPP_TYPE_BOOLEAN
    public partial class XRGraphicsAutomatedTests : DataModel
    {

        public static XRGraphicsAutomatedTests? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRGraphicsAutomatedTests() { Pointer= p0 };


            return value;
        }
    }
}
