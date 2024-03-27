using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 018 Amount                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ExpireDate                               0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 JumpParameter                            000186672F10 ModelPrimitiveType string string string String
    public partial class HomeRemindItemListViewModel
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
            var value   = new HomeRemindItemListViewModel();

            value.Product                                   = (ProductKey)GetInt32(new IntPtr(p + 0x010)); // 027005E18570 0x10 Product                     ( 0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x018)); // 027005E18590 0x18 Amount                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x020)); // 027005E185B0 0x20 ExpireDate                  ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.JumpParameter                             = GetString(new IntPtr(p + 0x028)); // 027005E185D0 0x28 JumpParameter               ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
