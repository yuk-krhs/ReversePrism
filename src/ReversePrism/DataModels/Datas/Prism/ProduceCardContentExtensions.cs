using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProduceCardDescription                   string IL2CPP_TYPE_STRING
    // 000 ReplaceRegex                             Regex IL2CPP_TYPE_CLASS
    public partial class ProduceCardContentExtensions : DataModel
    {

        public static ProduceCardContentExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardContentExtensions() { Pointer= p0 };


            return value;
        }
    }
}
