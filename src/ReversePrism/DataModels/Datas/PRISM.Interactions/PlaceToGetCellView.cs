using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 ItemIconView                             ModelClassType RequiredCurrentItemIconView RequiredCurrentItemIconView RequiredCurrentItemIconView Pointer
    // 048 ItemSectionHeight                        ModelPrimitiveType float float float Single
    // 050 TxtItemName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 PlaceSectionTopPadding                   ModelPrimitiveType float float float Single
    // 05C PlaceSectionBottomPadding                ModelPrimitiveType float float float Single
    // 060 PlaceListAreaTopPadding                  ModelPrimitiveType float float float Single
    // 064 PlaceListAreaBottomPadding               ModelPrimitiveType float float float Single
    // 068 PlaceListParent                          ModelClassType Transform Transform Transform Pointer
    // 070 PlaceColumnPrefab                        ModelClassType PlaceColumnView PlaceColumnView PlaceColumnView Pointer
    // 078 ColumnHeight                             ModelPrimitiveType float float float Single
    // 07C SpaceBetweenColumn                       ModelPrimitiveType float float float Single
    // 080 ActiveColumns                            ModelClassListType List`1<PlaceColumnView> List`1<PlaceColumnView> List<PlaceColumnView> Pointer
    // 088 CellHeight                               ModelPrimitiveType float float float Single
    // 090 columnPool                               ObjectPool`1<PlaceColumnView> IL2CPP_TYPE_GENERICINST
    public partial class PlaceToGetCellView : DataModel
    {
        public RectTransform?                           RectTransform                           { get; set; }
        public RequiredCurrentItemIconView?             ItemIconView                            { get; set; }
        public float                                    ItemSectionHeight                       { get; set; }
        public UITextMeshProUGUI?                       TxtItemName                             { get; set; }
        public float                                    PlaceSectionTopPadding                  { get; set; }
        public float                                    PlaceSectionBottomPadding               { get; set; }
        public float                                    PlaceListAreaTopPadding                 { get; set; }
        public float                                    PlaceListAreaBottomPadding              { get; set; }
        public Transform?                               PlaceListParent                         { get; set; }
        public PlaceColumnView?                         PlaceColumnPrefab                       { get; set; }
        public float                                    ColumnHeight                            { get; set; }
        public float                                    SpaceBetweenColumn                      { get; set; }
        public List<PlaceColumnView>?                   ActiveColumns                           { get; set; }
        public float                                    CellHeight                              { get; set; }

        public static PlaceToGetCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaceToGetCellView() { Pointer= p0 };

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ItemIconView                              = GetObject<RequiredCurrentItemIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.RequiredCurrentItemIconView.FromPointer); // 0x40 ItemIconView                ( ModelClassType RequiredCurrentItemIconView RequiredCurrentItemIconView RequiredCurrentItemIconView Pointer )
            value.ItemSectionHeight                         = GetSingle(new IntPtr(p + 0x048)); // 0x48 ItemSectionHeight           ( ModelPrimitiveType float float float Single )
            value.TxtItemName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtItemName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlaceSectionTopPadding                    = GetSingle(new IntPtr(p + 0x058)); // 0x58 PlaceSectionTopPadding      ( ModelPrimitiveType float float float Single )
            value.PlaceSectionBottomPadding                 = GetSingle(new IntPtr(p + 0x05C)); // 0x5C PlaceSectionBottomPadding   ( ModelPrimitiveType float float float Single )
            value.PlaceListAreaTopPadding                   = GetSingle(new IntPtr(p + 0x060)); // 0x60 PlaceListAreaTopPadding     ( ModelPrimitiveType float float float Single )
            value.PlaceListAreaBottomPadding                = GetSingle(new IntPtr(p + 0x064)); // 0x64 PlaceListAreaBottomPadding  ( ModelPrimitiveType float float float Single )
            value.PlaceListParent                           = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 PlaceListParent             ( ModelClassType Transform Transform Transform Pointer )
            value.PlaceColumnPrefab                         = GetObject<PlaceColumnView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PlaceColumnView.FromPointer); // 0x70 PlaceColumnPrefab           ( ModelClassType PlaceColumnView PlaceColumnView PlaceColumnView Pointer )
            value.ColumnHeight                              = GetSingle(new IntPtr(p + 0x078)); // 0x78 ColumnHeight                ( ModelPrimitiveType float float float Single )
            value.SpaceBetweenColumn                        = GetSingle(new IntPtr(p + 0x07C)); // 0x7C SpaceBetweenColumn          ( ModelPrimitiveType float float float Single )
            value.ActiveColumns                             = GetObjectList<PlaceColumnView>(new IntPtr(p + 0x080), ReversePrism.DataModels.PlaceColumnView.FromPointer); // 0x80 ActiveColumns               ( ModelClassListType List`1<PlaceColumnView> List`1<PlaceColumnView> List<PlaceColumnView> Pointer )
            value.CellHeight                                = GetSingle(new IntPtr(p + 0x088)); // 0x88 CellHeight                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
