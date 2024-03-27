using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeDiamondLv                          0001865F4260 ModelPrimitiveType int int int Int32
    // 014 AfterDiamondLv                           0001865F4260 ModelPrimitiveType int int int Int32
    // 018 LimitLvs                                 000185CF0078 ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer
    // 020 ProductKey                               0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 028 Required                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 030 Amount                                   0001865F8300 ModelPrimitiveType long long long Int64
    public partial class MasterTrainingExecutionConfirmedPopupViewModel
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
            var value   = new MasterTrainingExecutionConfirmedPopupViewModel();

            value.BeforeDiamondLv                           = GetInt32(new IntPtr(p + 0x010)); // 0270D5F770A8 0x10 BeforeDiamondLv             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterDiamondLv                            = GetInt32(new IntPtr(p + 0x014)); // 0270D5F770C8 0x14 AfterDiamondLv              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LimitLvs                                  = GetObjectList<LimitLvContentViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.LimitLvContentViewModel.FromPointer); // 0270D5F770E8 0x18 LimitLvs                    ( 000185CF0078 ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer )
            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x020)); // 0270D5F77108 0x20 ProductKey                  ( 0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Required                                  = GetInt32(new IntPtr(p + 0x028)); // 0270D5F77128 0x28 Required                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x030)); // 0270D5F77148 0x30 Amount                      ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
