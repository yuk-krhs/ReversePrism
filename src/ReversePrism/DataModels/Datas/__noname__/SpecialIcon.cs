using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductType                              000186611060 ModelEnumType ProductType ProductType ProductType Int32
    // 014 ProductMstId                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Object                                   0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    public partial class SpecialIcon : DataModel
    {
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }
        public GameObject?                              Object                                  { get; set; }

        public static SpecialIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialIcon() { Pointer= p0 };

            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x010)); // 02466537B758 0x10 ProductType                 ( 000186611060 ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x014)); // 02466537B778 0x14 ProductMstId                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Object                                    = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 02466537B798 0x18 Object                      ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
