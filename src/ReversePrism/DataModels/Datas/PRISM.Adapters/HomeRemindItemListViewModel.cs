using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  ModelEnumType ProductKey ProductKey ProductKey Int32
    // 018 Amount                                   ModelPrimitiveType int int int Int32
    // 020 ExpireDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 JumpParameter                            ModelPrimitiveType string string string String
    public partial class HomeRemindItemListViewModel : DataModel
    {
        public ProductKey                               Product                                 { get; set; }
        public int                                      Amount                                  { get; set; }
        public DateTime                                 ExpireDate                              { get; set; }
        public string                                   JumpParameter                           { get; set; }

        public static HomeRemindItemListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeRemindItemListViewModel() { Pointer= p0 };

            value.Product                                   = (ProductKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 Product                     ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Amount                      ( ModelPrimitiveType int int int Int32 )
            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ExpireDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.JumpParameter                             = GetString(new IntPtr(p + 0x028)); // 0x28 JumpParameter               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
