using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceIdolList                     000185D06B98 ModelClassListType IReadOnlyList`1<IProduceIdolStatus> IReadOnlyList`1<IProduceIdolStatus> List<IProduceIdolStatus> Pointer
    public partial class ProduceIdolListViewModel
    {
        public List<IProduceIdolStatus>?                CacheProduceIdolList                    { get; set; }

        public static ProduceIdolListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolListViewModel();

            value.CacheProduceIdolList                      = GetObjectList<IProduceIdolStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0270D65A4E38 0x10 CacheProduceIdolList        ( 000185D06B98 ModelClassListType IReadOnlyList`1<IProduceIdolStatus> IReadOnlyList`1<IProduceIdolStatus> List<IProduceIdolStatus> Pointer )

            return value;
        }
    }
}
