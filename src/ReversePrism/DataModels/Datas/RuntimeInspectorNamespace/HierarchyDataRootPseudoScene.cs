using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Name                                     ModelPrimitiveType string string string String
    // 040 RootObjects                              ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    public partial class HierarchyDataRootPseudoScene : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<Transform>?                         RootObjects                             { get; set; }

        public static HierarchyDataRootPseudoScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDataRootPseudoScene() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x038)); // 0x38 Name                        ( ModelPrimitiveType string string string String )
            value.RootObjects                               = GetObjectList<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 RootObjects                 ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )

            return value;
        }
    }
}
