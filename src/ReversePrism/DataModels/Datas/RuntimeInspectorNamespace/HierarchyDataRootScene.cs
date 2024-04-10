using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Scene                                    000186660100 ModelEnumType Scene Scene Scene Int32
    // 040 RootObjects                              000185CDD528 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class HierarchyDataRootScene : DataModel
    {
        public Scene                                    Scene                                   { get; set; }
        public List<GameObject>?                        RootObjects                             { get; set; }

        public static HierarchyDataRootScene? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyDataRootScene() { Pointer= p0 };

            value.Scene                                     = (Scene)GetInt32(new IntPtr(p + 0x038)); // 02466B218CC8 0x38 Scene                       ( 000186660100 ModelEnumType Scene Scene Scene Int32 )
            value.RootObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B218CE8 0x40 RootObjects                 ( 000185CDD528 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
