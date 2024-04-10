using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductKey                               0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 018 Master                                   000186740010 ModelClassType ICostume ICostume ICostume Pointer
    public partial class CostumeDetailPopupViewModel : DataModel
    {
        public ProductKey                               ProductKey                              { get; set; }
        public ICostume?                                Master                                  { get; set; }

        public static CostumeDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeDetailPopupViewModel() { Pointer= p0 };

            value.ProductKey                                = (ProductKey)GetInt32(new IntPtr(p + 0x010)); // 024665F8C308 0x10 ProductKey                  ( 0001865A2670 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.Master                                    = GetObject<ICostume>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICostume.FromPointer); // 024665F8C328 0x18 Master                      ( 000186740010 ModelClassType ICostume ICostume ICostume Pointer )

            return value;
        }
    }
}
