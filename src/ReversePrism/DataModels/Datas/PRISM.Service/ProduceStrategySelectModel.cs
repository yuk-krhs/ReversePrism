using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rnd                                      0001866093D0 ModelClassType Random Random Random Pointer
    public partial class ProduceStrategySelectModel
    {
        public Random?                                  Rnd                                     { get; set; }

        public static ProduceStrategySelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStrategySelectModel();

            value.Rnd                                       = GetObject<Random>(new IntPtr(p + 0x010), ReversePrism.DataModels.Random.FromPointer); // 0270D64680F8 0x10 Rnd                         ( 0001866093D0 ModelClassType Random Random Random Pointer )

            return value;
        }
    }
}
