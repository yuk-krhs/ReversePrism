using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CostumeSetName                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 DressIcon                                ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 050 HairstyleIcon                            ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 058 GlassesIcon                              ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 060 EarringsIcon                             ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 068 MakeupIcon                               ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 070 LockedObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 078 LockedTryOnModeObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 080 Data                                     ModelClassType CostumeSetListViewCellData CostumeSetListViewCellData CostumeSetListViewCellData Pointer
    // 088 IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    public partial class CostumeSetListViewCell : DataModel
    {
        public UITextMeshProUGUI?                       CostumeSetName                          { get; set; }
        public CostumeGridViewCell?                     DressIcon                               { get; set; }
        public CostumeGridViewCell?                     HairstyleIcon                           { get; set; }
        public CostumeGridViewCell?                     GlassesIcon                             { get; set; }
        public CostumeGridViewCell?                     EarringsIcon                            { get; set; }
        public CostumeGridViewCell?                     MakeupIcon                              { get; set; }
        public GameObject?                              LockedObject                            { get; set; }
        public GameObject?                              LockedTryOnModeObject                   { get; set; }
        public CostumeSetListViewCellData?              Data                                    { get; set; }
        public bool                                     IsUnlocked                              { get; set; }

        public static CostumeSetListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetListViewCell() { Pointer= p0 };

            value.CostumeSetName                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 CostumeSetName              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DressIcon                                 = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 0x48 DressIcon                   ( ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.HairstyleIcon                             = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 0x50 HairstyleIcon               ( ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.GlassesIcon                               = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x058), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 0x58 GlassesIcon                 ( ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.EarringsIcon                              = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 0x60 EarringsIcon                ( ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.MakeupIcon                                = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 0x68 MakeupIcon                  ( ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.LockedObject                              = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 LockedObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedTryOnModeObject                     = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 LockedTryOnModeObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Data                                      = GetObject<CostumeSetListViewCellData>(new IntPtr(p + 0x080), ReversePrism.DataModels.CostumeSetListViewCellData.FromPointer); // 0x80 Data                        ( ModelClassType CostumeSetListViewCellData CostumeSetListViewCellData CostumeSetListViewCellData Pointer )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x088)); // 0x88 IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
