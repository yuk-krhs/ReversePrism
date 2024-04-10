using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceBaseInfo                     0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    public partial class ProduceBaseInfoViewModel : DataModel
    {
        public IProduceBaseInfoStatus?                  CacheProduceBaseInfo                    { get; set; }

        public static ProduceBaseInfoViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceBaseInfoViewModel() { Pointer= p0 };

            value.CacheProduceBaseInfo                      = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0246666086E8 0x10 CacheProduceBaseInfo        ( 0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )

            return value;
        }
    }
}
