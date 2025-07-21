using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceStrategyListViewModel        ModelClassType ProduceStrategyListViewModel ProduceStrategyListViewModel ProduceStrategyListViewModel Pointer
    // 018 CacheProduceBaseInfoViewModel            ModelClassType ProduceBaseInfoViewModel ProduceBaseInfoViewModel ProduceBaseInfoViewModel Pointer
    public partial class ProducePolicyViewModel : DataModel
    {
        public ProduceStrategyListViewModel?            CacheProduceStrategyListViewModel       { get; set; }
        public ProduceBaseInfoViewModel?                CacheProduceBaseInfoViewModel           { get; set; }

        public static ProducePolicyViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyViewModel() { Pointer= p0 };

            value.CacheProduceStrategyListViewModel         = GetObject<ProduceStrategyListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceStrategyListViewModel.FromPointer); // 0x10 CacheProduceStrategyListViewModel ( ModelClassType ProduceStrategyListViewModel ProduceStrategyListViewModel ProduceStrategyListViewModel Pointer )
            value.CacheProduceBaseInfoViewModel             = GetObject<ProduceBaseInfoViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoViewModel.FromPointer); // 0x18 CacheProduceBaseInfoViewModel ( ModelClassType ProduceBaseInfoViewModel ProduceBaseInfoViewModel ProduceBaseInfoViewModel Pointer )

            return value;
        }
    }
}
