using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CollideTargetNames                       ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 018 ColliderParam                            ModelClassType AMagicaColliderParam AMagicaColliderParam AMagicaColliderParam Pointer
    public partial class ClothColliderData : DataModel
    {
        public List<string>?                            CollideTargetNames                      { get; set; }
        public AMagicaColliderParam?                    ColliderParam                           { get; set; }

        public static ClothColliderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothColliderData() { Pointer= p0 };

            value.CollideTargetNames                        = GetStringList(new IntPtr(p + 0x010)); // 0x10 CollideTargetNames          ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.ColliderParam                             = GetObject<AMagicaColliderParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.AMagicaColliderParam.FromPointer); // 0x18 ColliderParam               ( ModelClassType AMagicaColliderParam AMagicaColliderParam AMagicaColliderParam Pointer )

            return value;
        }
    }
}
