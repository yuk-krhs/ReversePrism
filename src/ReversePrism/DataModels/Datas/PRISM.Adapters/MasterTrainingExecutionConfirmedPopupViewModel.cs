using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeDiamondLv                          ModelPrimitiveType int int int Int32
    // 014 AfterDiamondLv                           ModelPrimitiveType int int int Int32
    // 018 LimitLvs                                 ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer
    // 020 ProductKey                               ModelEnumType ProductKey ProductKey ProductKey Int32
    // 028 Required                                 ModelPrimitiveType int int int Int32
    // 030 Amount                                   ModelPrimitiveType long long long Int64
    public partial class MasterTrainingExecutionConfirmedPopupViewModel : DataModel
    {
        public int                                      BeforeDiamondLv                         { get; set; }
        public int                                      AfterDiamondLv                          { get; set; }
        public List<LimitLvContentViewModel>?           LimitLvs                                { get; set; }
        public ProductKey                               ProductKey                              { get; set; }
        public int                                      Required                                { get; set; }
        public long                                     Amount                                  { get; set; }

        public static MasterTrainingExecutionConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterTrainingExecutionConfirmedPopupViewModel() { Pointer= p0 };

            value.BeforeDiamondLv                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 BeforeDiamondLv             ( ModelPrimitiveType int int int Int32 )
            value.AfterDiamondLv                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 AfterDiamondLv              ( ModelPrimitiveType int int int Int32 )
            value.LimitLvs                                  = GetObjectList<LimitLvContentViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.LimitLvContentViewModel.FromPointer); // 0x18 LimitLvs                    ( ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer )
            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 ProductKey                  ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Required                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 Required                    ( ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x030)); // 0x30 Amount                      ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
