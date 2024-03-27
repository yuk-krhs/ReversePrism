using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   000186689CF0 ModelClassType IUniTaskSource IUniTaskSource IUniTaskSource Pointer
    public partial class AsyncUnitSource
    {
        public IUniTaskSource?                          Source                                  { get; set; }

        public static AsyncUnitSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncUnitSource();

            value.Source                                    = GetObject<IUniTaskSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUniTaskSource.FromPointer); // 0270D8BE8E98 0x10 Source                      ( 000186689CF0 ModelClassType IUniTaskSource IUniTaskSource IUniTaskSource Pointer )

            return value;
        }
    }
}
