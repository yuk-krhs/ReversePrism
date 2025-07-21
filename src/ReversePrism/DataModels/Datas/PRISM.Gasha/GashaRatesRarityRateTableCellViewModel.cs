using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RarityRateList                           ModelClassListType List`1<GashaRatesRarityRateModel> List`1<GashaRatesRarityRateModel> List<GashaRatesRarityRateModel> Pointer
    public partial class GashaRatesRarityRateTableCellViewModel : DataModel
    {
        public List<GashaRatesRarityRateModel>?         RarityRateList                          { get; set; }

        public static GashaRatesRarityRateTableCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesRarityRateTableCellViewModel() { Pointer= p0 };

            value.RarityRateList                            = GetObjectList<GashaRatesRarityRateModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.GashaRatesRarityRateModel.FromPointer); // 0x10 RarityRateList              ( ModelClassListType List`1<GashaRatesRarityRateModel> List`1<GashaRatesRarityRateModel> List<GashaRatesRarityRateModel> Pointer )

            return value;
        }
    }
}
