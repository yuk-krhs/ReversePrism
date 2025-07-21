using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClothColliderDatas                       ModelClassListType List`1<ClothColliderSaveData> List`1<ClothColliderSaveData> List<ClothColliderSaveData> Pointer
    // 018 ColliderParamDatas                       ModelClassListType List`1<ColliderParamSaveData> List`1<ColliderParamSaveData> List<ColliderParamSaveData> Pointer
    public partial class MagicaColliderSaveData : DataModel
    {
        public List<ClothColliderSaveData>?             ClothColliderDatas                      { get; set; }
        public List<ColliderParamSaveData>?             ColliderParamDatas                      { get; set; }

        public static MagicaColliderSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaColliderSaveData() { Pointer= p0 };

            value.ClothColliderDatas                        = GetObjectList<ClothColliderSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ClothColliderSaveData.FromPointer); // 0x10 ClothColliderDatas          ( ModelClassListType List`1<ClothColliderSaveData> List`1<ClothColliderSaveData> List<ClothColliderSaveData> Pointer )
            value.ColliderParamDatas                        = GetObjectList<ColliderParamSaveData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ColliderParamSaveData.FromPointer); // 0x18 ColliderParamDatas          ( ModelClassListType List`1<ColliderParamSaveData> List`1<ColliderParamSaveData> List<ColliderParamSaveData> Pointer )

            return value;
        }
    }
}
