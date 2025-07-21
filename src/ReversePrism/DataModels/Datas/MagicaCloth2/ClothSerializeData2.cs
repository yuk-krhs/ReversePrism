using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectionData                            ModelClassType SelectionData SelectionData SelectionData Pointer
    // 018 boneAttributeDict                        Dictionary`2<Transform, VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 020 PreBuildData                             ModelClassType PreBuildSerializeData PreBuildSerializeData PreBuildSerializeData Pointer
    public partial class ClothSerializeData2 : DataModel
    {
        public SelectionData?                           SelectionData                           { get; set; }
        public PreBuildSerializeData?                   PreBuildData                            { get; set; }

        public static ClothSerializeData2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothSerializeData2() { Pointer= p0 };

            value.SelectionData                             = GetObject<SelectionData>(new IntPtr(p + 0x010), ReversePrism.DataModels.SelectionData.FromPointer); // 0x10 SelectionData               ( ModelClassType SelectionData SelectionData SelectionData Pointer )
            value.PreBuildData                              = GetObject<PreBuildSerializeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.PreBuildSerializeData.FromPointer); // 0x20 PreBuildData                ( ModelClassType PreBuildSerializeData PreBuildSerializeData PreBuildSerializeData Pointer )

            return value;
        }
    }
}
