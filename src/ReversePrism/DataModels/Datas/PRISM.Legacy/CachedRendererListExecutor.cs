using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CachedMaterialList                       000185CF2148 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 018 CachedRoot                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class CachedRendererListExecutor : DataModel
    {
        public List<Material>?                          CachedMaterialList                      { get; set; }
        public GameObject?                              CachedRoot                              { get; set; }

        public static CachedRendererListExecutor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedRendererListExecutor() { Pointer= p0 };

            value.CachedMaterialList                        = GetObjectList<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 024660EC2B70 0x10 CachedMaterialList          ( 000185CF2148 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.CachedRoot                                = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 024660EC2B90 0x18 CachedRoot                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
