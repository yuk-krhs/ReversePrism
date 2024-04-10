using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               0001866C4C00 ModelClassType IdolStoryFirstCategoryCell IdolStoryFirstCategoryCell IdolStoryFirstCategoryCell Pointer
    // 028 CellPos                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 UnitIconImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 onClickCellSubject                       Subject`1<IdolStoryFirstCategoryCellData> IL2CPP_TYPE_GENERICINST
    // 040 ReadCells                                000185CDD528 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 048 IsAllRead                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class IdolStoryFirstCategoryCellGroup : DataModel
    {
        public IdolStoryFirstCategoryCell?              CellPrefab                              { get; set; }
        public Transform?                               CellPos                                 { get; set; }
        public UIImage?                                 UnitIconImage                           { get; set; }
        public List<GameObject>?                        ReadCells                               { get; set; }
        public bool                                     IsAllRead                               { get; set; }

        public static IdolStoryFirstCategoryCellGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStoryFirstCategoryCellGroup() { Pointer= p0 };

            value.CellPrefab                                = GetObject<IdolStoryFirstCategoryCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStoryFirstCategoryCell.FromPointer); // 02466BA0E158 0x20 CellPrefab                  ( 0001866C4C00 ModelClassType IdolStoryFirstCategoryCell IdolStoryFirstCategoryCell IdolStoryFirstCategoryCell Pointer )
            value.CellPos                                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466BA0E178 0x28 CellPos                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.UnitIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 02466BA0E198 0x30 UnitIconImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ReadCells                                 = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA0E1D8 0x40 ReadCells                   ( 000185CDD528 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.IsAllRead                                 = GetBool(new IntPtr(p + 0x048)); // 02466BA0E1F8 0x48 IsAllRead                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
