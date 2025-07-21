using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelClassType IPvpUnitStatus IPvpUnitStatus IPvpUnitStatus Pointer
    // 018 <ProduceCards>k__BackingField            IEnumerable`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    public partial class PvpUnitViewModel : DataModel
    {
        public IPvpUnitStatus?                          Status                                  { get; set; }

        public static PvpUnitViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IPvpUnitStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPvpUnitStatus.FromPointer); // 0x10 Status                      ( ModelClassType IPvpUnitStatus IPvpUnitStatus IPvpUnitStatus Pointer )

            return value;
        }
    }
}
