using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceStrategyList                      000185CE7A88 ModelClassListType List`1<IProduceStrategyStatus> List`1<IProduceStrategyStatus> List<IProduceStrategyStatus> Pointer
    public partial class ProduceStrategyListViewModel : DataModel
    {
        public List<IProduceStrategyStatus>?            ProduceStrategyList                     { get; set; }

        public static ProduceStrategyListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStrategyListViewModel() { Pointer= p0 };

            value.ProduceStrategyList                       = GetObjectList<IProduceStrategyStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceStrategyStatus.FromPointer); // 024666608300 0x10 ProduceStrategyList         ( 000185CE7A88 ModelClassListType List`1<IProduceStrategyStatus> List`1<IProduceStrategyStatus> List<IProduceStrategyStatus> Pointer )

            return value;
        }
    }
}
