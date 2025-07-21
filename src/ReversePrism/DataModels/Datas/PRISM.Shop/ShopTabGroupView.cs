using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 TabItemPrefab                            ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer
    // 030 OnSelected                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 CurrentSelectedItem                      ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer
    // 040 TabItems                                 ModelClassListType List`1<ShopTabItem> List`1<ShopTabItem> List<ShopTabItem> Pointer
    // 048 ShopLocalSave                            ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer
    // 050 CostumeTabNum                            ModelPrimitiveType int int int Int32
    // 054 LastSelectIndex                          ModelPrimitiveType int int int Int32
    public partial class ShopTabGroupView : DataModel
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public ShopTabItem?                             TabItemPrefab                           { get; set; }
        public ShopTabItem?                             CurrentSelectedItem                     { get; set; }
        public List<ShopTabItem>?                       TabItems                                { get; set; }
        public ShopLocalSave?                           ShopLocalSave                           { get; set; }
        public int                                      CostumeTabNum                           { get; set; }
        public int                                      LastSelectIndex                         { get; set; }

        public static ShopTabGroupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopTabGroupView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabItemPrefab                             = GetObject<ShopTabItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopTabItem.FromPointer); // 0x28 TabItemPrefab               ( ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer )
            value.CurrentSelectedItem                       = GetObject<ShopTabItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopTabItem.FromPointer); // 0x38 CurrentSelectedItem         ( ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer )
            value.TabItems                                  = GetObjectList<ShopTabItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopTabItem.FromPointer); // 0x40 TabItems                    ( ModelClassListType List`1<ShopTabItem> List`1<ShopTabItem> List<ShopTabItem> Pointer )
            value.ShopLocalSave                             = GetObject<ShopLocalSave>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopLocalSave.FromPointer); // 0x48 ShopLocalSave               ( ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer )
            value.CostumeTabNum                             = GetInt32(new IntPtr(p + 0x050)); // 0x50 CostumeTabNum               ( ModelPrimitiveType int int int Int32 )
            value.LastSelectIndex                           = GetInt32(new IntPtr(p + 0x054)); // 0x54 LastSelectIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
