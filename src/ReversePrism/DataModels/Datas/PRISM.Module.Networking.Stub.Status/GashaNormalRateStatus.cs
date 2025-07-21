using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaNormalRateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RarityRateListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_rarityRateList_codec           FieldCodec`1<GashaRarityRateStatus> IL2CPP_TYPE_GENERICINST
    // 018 RarityRateList                           ModelClassListType RepeatedField`1<GashaRarityRateStatus> RepeatedField`1<GashaRarityRateStatus> List<GashaRarityRateStatus> Pointer
    // 000 ProductRateListFieldNumber               int IL2CPP_TYPE_I4
    // 010 _repeated_productRateList_codec          FieldCodec`1<GashaProductRateStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProductRateList                          ModelClassListType RepeatedField`1<GashaProductRateStatus> RepeatedField`1<GashaProductRateStatus> List<GashaProductRateStatus> Pointer
    public partial class GashaNormalRateStatus : DataModel
    {
        public List<GashaRarityRateStatus>?             RarityRateList                          { get; set; }
        public List<GashaProductRateStatus>?            ProductRateList                         { get; set; }

        public static GashaNormalRateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaNormalRateStatus() { Pointer= p0 };

            value.RarityRateList                            = GetObjectList<GashaRarityRateStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaRarityRateStatus.FromPointer); // 0x18 RarityRateList              ( ModelClassListType RepeatedField`1<GashaRarityRateStatus> RepeatedField`1<GashaRarityRateStatus> List<GashaRarityRateStatus> Pointer )
            value.ProductRateList                           = GetObjectList<GashaProductRateStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductRateStatus.FromPointer); // 0x20 ProductRateList             ( ModelClassListType RepeatedField`1<GashaProductRateStatus> RepeatedField`1<GashaProductRateStatus> List<GashaProductRateStatus> Pointer )

            return value;
        }
    }
}
