using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseRect                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 RectContent                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 RequiredItemIconGroupPrefab              ModelClassType RequiredItemIconGroup RequiredItemIconGroup RequiredItemIconGroup Pointer
    // 038 ContentParent                            ModelClassType Transform Transform Transform Pointer
    // 040 BtnNext                                  ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnBefore                                ModelClassType UIButton UIButton UIButton Pointer
    // 050 CarouselIndicator                        ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer
    // 058 VisiblePagesCount                        ModelPrimitiveType int int int Int32
    // 05C CurrentPageNum                           ModelPrimitiveType int int int Int32
    // 060 ItemGroups                               ModelClassListType List`1<RequiredItemIconGroup> List`1<RequiredItemIconGroup> List<RequiredItemIconGroup> Pointer
    // 068 ItemGroupWidth                           ModelPrimitiveType float float float Single
    public partial class ItemPager : DataModel
    {
        public RectTransform?                           BaseRect                                { get; set; }
        public RectTransform?                           RectContent                             { get; set; }
        public RequiredItemIconGroup?                   RequiredItemIconGroupPrefab             { get; set; }
        public Transform?                               ContentParent                           { get; set; }
        public UIButton?                                BtnNext                                 { get; set; }
        public UIButton?                                BtnBefore                               { get; set; }
        public CarouselIndicator?                       CarouselIndicator                       { get; set; }
        public int                                      VisiblePagesCount                       { get; set; }
        public int                                      CurrentPageNum                          { get; set; }
        public List<RequiredItemIconGroup>?             ItemGroups                              { get; set; }
        public float                                    ItemGroupWidth                          { get; set; }

        public static ItemPager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemPager() { Pointer= p0 };

            value.BaseRect                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 BaseRect                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectContent                               = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0x28 RectContent                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RequiredItemIconGroupPrefab               = GetObject<RequiredItemIconGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.RequiredItemIconGroup.FromPointer); // 0x30 RequiredItemIconGroupPrefab ( ModelClassType RequiredItemIconGroup RequiredItemIconGroup RequiredItemIconGroup Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 ContentParent               ( ModelClassType Transform Transform Transform Pointer )
            value.BtnNext                                   = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnNext                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnBefore                                 = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 BtnBefore                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CarouselIndicator                         = GetObject<CarouselIndicator>(new IntPtr(p + 0x050), ReversePrism.DataModels.CarouselIndicator.FromPointer); // 0x50 CarouselIndicator           ( ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer )
            value.VisiblePagesCount                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 VisiblePagesCount           ( ModelPrimitiveType int int int Int32 )
            value.CurrentPageNum                            = GetInt32(new IntPtr(p + 0x05C)); // 0x5C CurrentPageNum              ( ModelPrimitiveType int int int Int32 )
            value.ItemGroups                                = GetObjectList<RequiredItemIconGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.RequiredItemIconGroup.FromPointer); // 0x60 ItemGroups                  ( ModelClassListType List`1<RequiredItemIconGroup> List`1<RequiredItemIconGroup> List<RequiredItemIconGroup> Pointer )
            value.ItemGroupWidth                            = GetSingle(new IntPtr(p + 0x068)); // 0x68 ItemGroupWidth              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
