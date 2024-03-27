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
    public partial class SpecialIcon
    {
        public ProductType                              ProductType                             { get; set; }
        public int                                      ProductMstId                            { get; set; }
        public GameObject?                              Object                                  { get; set; }

        public static SpecialIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialIcon();

            value.ProductType                               = (ProductType)GetInt32(new IntPtr(p + 0x010)); // 0270D5307F90 0x10 ProductType                 ( 000186611060 ModelEnumType ProductType ProductType ProductType Int32 )
            value.ProductMstId                              = GetInt32(new IntPtr(p + 0x014)); // 0270D5307FB0 0x14 ProductMstId                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Object                                    = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5307FD0 0x18 Object                      ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
