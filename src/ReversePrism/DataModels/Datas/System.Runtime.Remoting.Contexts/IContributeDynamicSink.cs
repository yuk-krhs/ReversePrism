using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class IContributeDynamicSink : DataModel
    {

        public static IContributeDynamicSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IContributeDynamicSink() { Pointer= p0 };


            return value;
        }
    }
}
