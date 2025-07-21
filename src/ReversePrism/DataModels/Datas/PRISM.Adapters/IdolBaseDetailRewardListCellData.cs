using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lv                                       ModelPrimitiveType int int int Int32
    // 018 ItemRewards                              ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 020 StatusReward                             ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 028 IsArchived                               ModelPrimitiveType bool bool bool Bool
    public partial class IdolBaseDetailRewardListCellData : DataModel
    {
        public int                                      Lv                                      { get; set; }
        public List<IProductWithAmountStatus>?          ItemRewards                             { get; set; }
        public IIdolParameterStatus?                    StatusReward                            { get; set; }
        public bool                                     IsArchived                              { get; set; }

        public static IdolBaseDetailRewardListCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailRewardListCellData() { Pointer= p0 };

            value.Lv                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Lv                          ( ModelPrimitiveType int int int Int32 )
            value.ItemRewards                               = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x18 ItemRewards                 ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.StatusReward                              = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 0x20 StatusReward                ( ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.IsArchived                                = GetBool(new IntPtr(p + 0x028)); // 0x28 IsArchived                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
