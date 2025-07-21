using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Logger                                   ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer
    public partial class GleipnirLogger : DataModel
    {
        public CategorizedLogger?                       Logger                                  { get; set; }

        public static GleipnirLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GleipnirLogger() { Pointer= p0 };

            value.Logger                                    = GetObject<CategorizedLogger>(new IntPtr(p + 0x010), ReversePrism.DataModels.CategorizedLogger.FromPointer); // 0x10 Logger                      ( ModelClassType CategorizedLogger CategorizedLogger CategorizedLogger Pointer )

            return value;
        }
    }
}
