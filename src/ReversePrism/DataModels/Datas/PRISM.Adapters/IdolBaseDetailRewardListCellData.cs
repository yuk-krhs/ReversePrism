using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lv                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ItemRewards                              000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 020 StatusReward                             000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 028 IsArchived                               0001865965D0 ModelPrimitiveType bool bool bool Bool
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

            value.Lv                                        = GetInt32(new IntPtr(p + 0x010)); // 024665F194E8 0x10 Lv                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ItemRewards                               = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024665F19508 0x18 ItemRewards                 ( 000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.StatusReward                              = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 024665F19528 0x20 StatusReward                ( 000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.IsArchived                                = GetBool(new IntPtr(p + 0x028)); // 024665F19548 0x28 IsArchived                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
