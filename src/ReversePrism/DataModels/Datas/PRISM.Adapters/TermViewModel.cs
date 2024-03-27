using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceTerm                         0001865F57A0 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer
    public partial class TermViewModel
    {
        public IProduceTermStatus?                      CacheProduceTerm                        { get; set; }

        public static TermViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TermViewModel();

            value.CacheProduceTerm                          = GetObject<IProduceTermStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceTermStatus.FromPointer); // 0270D65C7918 0x10 CacheProduceTerm            ( 0001865F57A0 ModelClassType IProduceTermStatus IProduceTermStatus IProduceTermStatus Pointer )

            return value;
        }
    }
}
