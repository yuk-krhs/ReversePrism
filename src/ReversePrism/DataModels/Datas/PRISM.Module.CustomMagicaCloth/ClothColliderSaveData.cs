using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClothName                                ModelPrimitiveType string string string String
    // 018 CollideCategories                        ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class ClothColliderSaveData : DataModel
    {
        public string                                   ClothName                               { get; set; }
        public List<string>?                            CollideCategories                       { get; set; }

        public static ClothColliderSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothColliderSaveData() { Pointer= p0 };

            value.ClothName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 ClothName                   ( ModelPrimitiveType string string string String )
            value.CollideCategories                         = GetStringList(new IntPtr(p + 0x018)); // 0x18 CollideCategories           ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
