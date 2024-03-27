using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GroupId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstExchangeProductId                     0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ItemName                                 000186672F10 ModelPrimitiveType string string string String
    // 020 ExchangeProduct                          0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 028 ContentDetailProductList                 000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 030 UseProduct                               0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 038 PurchaseDate                             0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 SelectionTicketProductId                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ExchangeHistoryItemViewModel
    {
        public int                                      GroupId                                 { get; set; }
        public int                                      MstExchangeProductId                    { get; set; }
        public string                                   ItemName                                { get; set; }
        public IProductWithAmountStatus?                ExchangeProduct                         { get; set; }
        public List<IProductWithAmountStatus>?          ContentDetailProductList                { get; set; }
        public IProductWithAmountStatus?                UseProduct                              { get; set; }
        public DateTime                                 PurchaseDate                            { get; set; }
        public int                                      SelectionTicketProductId                { get; set; }

        public static ExchangeHistoryItemViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryItemViewModel();

            value.GroupId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D62E3C10 0x10 GroupId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstExchangeProductId                      = GetInt32(new IntPtr(p + 0x014)); // 0270D62E3C30 0x14 MstExchangeProductId        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ItemName                                  = GetString(new IntPtr(p + 0x018)); // 0270D62E3C50 0x18 ItemName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.ExchangeProduct                           = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62E3C70 0x20 ExchangeProduct             ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ContentDetailProductList                  = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62E3C90 0x28 ContentDetailProductList    ( 000185D076C8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.UseProduct                                = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62E3CB0 0x30 UseProduct                  ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x038)); // 0270D62E3CD0 0x38 PurchaseDate                ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SelectionTicketProductId                  = GetInt32(new IntPtr(p + 0x040)); // 0270D62E3CF0 0x40 SelectionTicketProductId    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
