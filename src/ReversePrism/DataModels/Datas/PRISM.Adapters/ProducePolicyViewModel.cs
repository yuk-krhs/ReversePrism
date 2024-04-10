using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheProduceStrategyListViewModel        000186583C40 ModelClassType ProduceStrategyListViewModel ProduceStrategyListViewModel ProduceStrategyListViewModel Pointer
    // 018 CacheProduceBaseInfoViewModel            000186533A20 ModelClassType ProduceBaseInfoViewModel ProduceBaseInfoViewModel ProduceBaseInfoViewModel Pointer
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

            value.CacheProduceStrategyListViewModel         = GetObject<ProduceStrategyListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceStrategyListViewModel.FromPointer); // 024666610DC8 0x10 CacheProduceStrategyListViewModel ( 000186583C40 ModelClassType ProduceStrategyListViewModel ProduceStrategyListViewModel ProduceStrategyListViewModel Pointer )
            value.CacheProduceBaseInfoViewModel             = GetObject<ProduceBaseInfoViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoViewModel.FromPointer); // 024666610DE8 0x18 CacheProduceBaseInfoViewModel ( 000186533A20 ModelClassType ProduceBaseInfoViewModel ProduceBaseInfoViewModel ProduceBaseInfoViewModel Pointer )

            return value;
        }
    }
}
