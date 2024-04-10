using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseRect                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 RectContent                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 RequiredItemIconGroupPrefab              00018666B160 ModelClassType RequiredItemIconGroup RequiredItemIconGroup RequiredItemIconGroup Pointer
    // 038 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 040 BtnNext                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnBefore                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 CarouselIndicator                        000186547E60 ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer
    // 058 VisiblePagesCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C CurrentPageNum                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 ItemGroups                               000185D02A48 ModelClassListType List`1<RequiredItemIconGroup> List`1<RequiredItemIconGroup> List<RequiredItemIconGroup> Pointer
    // 068 ItemGroupWidth                           0001866656B0 ModelPrimitiveType float float float Single
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

            value.BaseRect                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2C8F30 0x20 BaseRect                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectContent                               = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A2C8F50 0x28 RectContent                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RequiredItemIconGroupPrefab               = GetObject<RequiredItemIconGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.RequiredItemIconGroup.FromPointer); // 02466A2C8F70 0x30 RequiredItemIconGroupPrefab ( 00018666B160 ModelClassType RequiredItemIconGroup RequiredItemIconGroup RequiredItemIconGroup Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 02466A2C8F90 0x38 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.BtnNext                                   = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2C8FB0 0x40 BtnNext                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnBefore                                 = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2C8FD0 0x48 BtnBefore                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CarouselIndicator                         = GetObject<CarouselIndicator>(new IntPtr(p + 0x050), ReversePrism.DataModels.CarouselIndicator.FromPointer); // 02466A2C8FF0 0x50 CarouselIndicator           ( 000186547E60 ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer )
            value.VisiblePagesCount                         = GetInt32(new IntPtr(p + 0x058)); // 02466A2C9010 0x58 VisiblePagesCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentPageNum                            = GetInt32(new IntPtr(p + 0x05C)); // 02466A2C9030 0x5C CurrentPageNum              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ItemGroups                                = GetObjectList<RequiredItemIconGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.RequiredItemIconGroup.FromPointer); // 02466A2C9050 0x60 ItemGroups                  ( 000185D02A48 ModelClassListType List`1<RequiredItemIconGroup> List`1<RequiredItemIconGroup> List<RequiredItemIconGroup> Pointer )
            value.ItemGroupWidth                            = GetSingle(new IntPtr(p + 0x068)); // 02466A2C9070 0x68 ItemGroupWidth              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
