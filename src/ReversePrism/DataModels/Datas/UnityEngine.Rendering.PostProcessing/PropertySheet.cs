using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Properties                               ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 018 Material                                 ModelClassType Material Material Material Pointer
    public partial class PropertySheet : DataModel
    {
        public MaterialPropertyBlock?                   Properties                              { get; set; }
        public Material?                                Material                                { get; set; }

        public static PropertySheet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertySheet() { Pointer= p0 };

            value.Properties                                = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x010), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0x10 Properties                  ( ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 Material                    ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
