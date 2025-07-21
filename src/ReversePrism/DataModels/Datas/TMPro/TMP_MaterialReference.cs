using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Material                                 ModelClassType Material Material Material Pointer
    // 018 ReferenceCount                           ModelPrimitiveType int int int Int32
    public partial class TMP_MaterialReference : DataModel
    {
        public Material?                                Material                                { get; set; }
        public int                                      ReferenceCount                          { get; set; }

        public static TMP_MaterialReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_MaterialReference() { Pointer= p0 };

            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 Material                    ( ModelClassType Material Material Material Pointer )
            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 ReferenceCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
