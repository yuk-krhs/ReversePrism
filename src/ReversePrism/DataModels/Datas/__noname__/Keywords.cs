using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  EventKeywords IL2CPP_TYPE_VALUETYPE
    // 000 Debug                                    EventKeywords IL2CPP_TYPE_VALUETYPE
    // 000 EnterExit                                EventKeywords IL2CPP_TYPE_VALUETYPE
    public partial class Keywords : DataModel
    {

        public static Keywords? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Keywords() { Pointer= p0 };


            return value;
        }
    }
}
