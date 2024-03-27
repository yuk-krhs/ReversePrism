using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SeasonPass                               0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 018 LoginPass                                0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    public partial class HomeHeaderPassContentViewModel
    {
        public IProductStatus?                          SeasonPass                              { get; set; }
        public IProductStatus?                          LoginPass                               { get; set; }

        public static HomeHeaderPassContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeHeaderPassContentViewModel();

            value.SeasonPass                                = GetObject<IProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductStatus.FromPointer); // 027004F48340 0x10 SeasonPass                  ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.LoginPass                                 = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 027004F48360 0x18 LoginPass                   ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )

            return value;
        }
    }
}
