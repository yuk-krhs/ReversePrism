using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelPrimitiveType string string string String
    // 018 ColliderControllers                      ModelClassListType List`1<AMagicaBodyParamColliderController> List`1<AMagicaBodyParamColliderController> List<AMagicaBodyParamColliderController> Pointer
    public partial class MagicaColliderCategoryData : DataModel
    {
        public string                                   Category                                { get; set; }
        public List<AMagicaBodyParamColliderController>? ColliderControllers                     { get; set; }

        public static MagicaColliderCategoryData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaColliderCategoryData() { Pointer= p0 };

            value.Category                                  = GetString(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelPrimitiveType string string string String )
            value.ColliderControllers                       = GetObjectList<AMagicaBodyParamColliderController>(new IntPtr(p + 0x018), ReversePrism.DataModels.AMagicaBodyParamColliderController.FromPointer); // 0x18 ColliderControllers         ( ModelClassListType List`1<AMagicaBodyParamColliderController> List`1<AMagicaBodyParamColliderController> List<AMagicaBodyParamColliderController> Pointer )

            return value;
        }
    }
}
