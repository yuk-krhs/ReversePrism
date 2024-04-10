using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 field                                    <object> IL2CPP_TYPE_OBJECT
    public partial class SmallXmlNodeList : DataModel
    {

        public static SmallXmlNodeList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SmallXmlNodeList() { Pointer= p0 };


            return value;
        }
    }
}
