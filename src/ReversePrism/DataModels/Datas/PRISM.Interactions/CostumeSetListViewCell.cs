using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CostumeSetName                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 DressIcon                                00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 050 HairstyleIcon                            00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 058 GlassesIcon                              00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 060 EarringsIcon                             00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 068 MakeupIcon                               00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer
    // 070 LockedObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 LockedTryOnModeObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 Data                                     000186634610 ModelClassType CostumeSetListViewCellData CostumeSetListViewCellData CostumeSetListViewCellData Pointer
    // 088 IsUnlocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.CostumeSetName                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B43C3A8 0x40 CostumeSetName              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DressIcon                                 = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 02466B43C3C8 0x48 DressIcon                   ( 00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.HairstyleIcon                             = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 02466B43C3E8 0x50 HairstyleIcon               ( 00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.GlassesIcon                               = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x058), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 02466B43C408 0x58 GlassesIcon                 ( 00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.EarringsIcon                              = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 02466B43C428 0x60 EarringsIcon                ( 00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.MakeupIcon                                = GetObject<CostumeGridViewCell>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeGridViewCell.FromPointer); // 02466B43C448 0x68 MakeupIcon                  ( 00018662CD20 ModelClassType CostumeGridViewCell CostumeGridViewCell CostumeGridViewCell Pointer )
            value.LockedObject                              = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466B43C468 0x70 LockedObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockedTryOnModeObject                     = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466B43C488 0x78 LockedTryOnModeObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Data                                      = GetObject<CostumeSetListViewCellData>(new IntPtr(p + 0x080), ReversePrism.DataModels.CostumeSetListViewCellData.FromPointer); // 02466B43C4A8 0x80 Data                        ( 000186634610 ModelClassType CostumeSetListViewCellData CostumeSetListViewCellData CostumeSetListViewCellData Pointer )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x088)); // 02466B43C4C8 0x88 IsUnlocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
