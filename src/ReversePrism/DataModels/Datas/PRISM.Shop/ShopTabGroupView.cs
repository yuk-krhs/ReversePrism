using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 TabItemPrefab                            000186773910 ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer
    // 030 OnSelected                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 CurrentSelectedItem                      000186773910 ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer
    // 040 TabItems                                 000185D09A08 ModelClassListType List`1<ShopTabItem> List`1<ShopTabItem> List<ShopTabItem> Pointer
    // 048 ShopLocalSave                            0001867622A0 ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer
    // 050 CostumeTabNum                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 LastSelectIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ShopTabGroupView
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
            var value   = new ShopTabGroupView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270D553ACA8 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabItemPrefab                             = GetObject<ShopTabItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopTabItem.FromPointer); // 0270D553ACC8 0x28 TabItemPrefab               ( 000186773910 ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer )
            value.CurrentSelectedItem                       = GetObject<ShopTabItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopTabItem.FromPointer); // 0270D553AD08 0x38 CurrentSelectedItem         ( 000186773910 ModelClassType ShopTabItem ShopTabItem ShopTabItem Pointer )
            value.TabItems                                  = GetObjectList<ShopTabItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopTabItem.FromPointer); // 0270D553AD28 0x40 TabItems                    ( 000185D09A08 ModelClassListType List`1<ShopTabItem> List`1<ShopTabItem> List<ShopTabItem> Pointer )
            value.ShopLocalSave                             = GetObject<ShopLocalSave>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopLocalSave.FromPointer); // 0270D553AD48 0x48 ShopLocalSave               ( 0001867622A0 ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer )
            value.CostumeTabNum                             = GetInt32(new IntPtr(p + 0x050)); // 0270D553AD68 0x50 CostumeTabNum               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastSelectIndex                           = GetInt32(new IntPtr(p + 0x054)); // 0270D553AD88 0x54 LastSelectIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
