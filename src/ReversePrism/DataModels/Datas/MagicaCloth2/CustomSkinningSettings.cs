using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 018 SkinningBones                            ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    public partial class CustomSkinningSettings : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public List<Transform>?                         SkinningBones                           { get; set; }

        public static CustomSkinningSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomSkinningSettings() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.SkinningBones                             = GetObjectList<Transform>(new IntPtr(p + 0x018), ReversePrism.DataModels.Transform.FromPointer); // 0x18 SkinningBones               ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )

            return value;
        }
    }
}
