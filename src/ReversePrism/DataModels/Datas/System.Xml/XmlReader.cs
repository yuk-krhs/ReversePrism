using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 IsTextualNodeBitmap                      uint IL2CPP_TYPE_U4
    // 004 CanReadContentAsBitmap                   uint IL2CPP_TYPE_U4
    // 008 HasValueBitmap                           uint IL2CPP_TYPE_U4
    public partial class XmlReader : DataModel
    {

        public static XmlReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlReader() { Pointer= p0 };


            return value;
        }
    }
}
