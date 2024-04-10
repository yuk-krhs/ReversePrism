using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Content                                  000186671910 ModelPrimitiveType string string string String
    public partial class ADVLogActionNodeViewModel : DataModel
    {
        public string                                   Content                                 { get; set; }

        public static ADVLogActionNodeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogActionNodeViewModel() { Pointer= p0 };

            value.Content                                   = GetString(new IntPtr(p + 0x010)); // 024666989D98 0x10 Content                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
