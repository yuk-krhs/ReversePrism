using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeStar                               0001865F4260 ModelPrimitiveType int int int Int32
    // 014 AfterStar                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 BeforeIdolParam                          000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 020 AfterIdolParam                           000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    // 028 OtherBonusViewModel                      0001866EED30 ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer
    // 030 ProductKey                               0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 038 Amount                                   0001865F8300 ModelPrimitiveType long long long Int64
    // 040 Required                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class PITrainingExecutionConfirmedPopupViewModel : DataModel
    {
        public int                                      BeforeStar                              { get; set; }
        public int                                      AfterStar                               { get; set; }
        public IIdolParameterStatus?                    BeforeIdolParam                         { get; set; }
        public IIdolParameterStatus?                    AfterIdolParam                          { get; set; }
        public OtherBonusViewModel?                     OtherBonusViewModel                     { get; set; }
        public ProductKey                               ProductKey                              { get; set; }
        public long                                     Amount                                  { get; set; }
        public int                                      Required                                { get; set; }

        public static PITrainingExecutionConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PITrainingExecutionConfirmedPopupViewModel() { Pointer= p0 };

            value.BeforeStar                                = GetInt32(new IntPtr(p + 0x010)); // 0246660051D0 0x10 BeforeStar                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterStar                                 = GetInt32(new IntPtr(p + 0x014)); // 0246660051F0 0x14 AfterStar                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BeforeIdolParam                           = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 024666005210 0x18 BeforeIdolParam             ( 000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.AfterIdolParam                            = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 024666005230 0x20 AfterIdolParam              ( 000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )
            value.OtherBonusViewModel                       = GetObject<OtherBonusViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.OtherBonusViewModel.FromPointer); // 024666005250 0x28 OtherBonusViewModel         ( 0001866EED30 ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer )
            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x030)); // 024666005270 0x30 ProductKey                  ( 0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x038)); // 024666005290 0x38 Amount                      ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.Required                                  = GetInt32(new IntPtr(p + 0x040)); // 0246660052B0 0x40 Required                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
