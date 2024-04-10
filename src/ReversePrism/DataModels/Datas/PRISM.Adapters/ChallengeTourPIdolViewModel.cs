using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceIdol                              000186546CA0 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
    // 018 PIdolIcon                                00018670C7D0 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 020 Parameter                                0001865EF590 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    public partial class ChallengeTourPIdolViewModel : DataModel
    {
        public ProduceIdol?                             ProduceIdol                             { get; set; }
        public PIdolIcon?                               PIdolIcon                               { get; set; }
        public IProduceParameterStatus?                 Parameter                               { get; set; }

        public static ChallengeTourPIdolViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolViewModel() { Pointer= p0 };

            value.ProduceIdol                               = GetObject<ProduceIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceIdol.FromPointer); // 024666520D50 0x10 ProduceIdol                 ( 000186546CA0 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )
            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.PIdolIcon.FromPointer); // 024666520D70 0x18 PIdolIcon                   ( 00018670C7D0 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 024666520D90 0x20 Parameter                   ( 0001865EF590 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
