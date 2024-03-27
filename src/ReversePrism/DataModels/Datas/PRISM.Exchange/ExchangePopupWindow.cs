using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 TabPrefab                                0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    // 068 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 070 TabDatas                                 000185D23198 ModelClassListType List`1<TabData> List`1<TabData> List<TabData> Pointer
    // 078 CurSelectTabData                         00018664D250 ModelClassType TabData TabData TabData Pointer
    // 080 GoodsGridView                            000186509BA0 ModelClassType ExchangeGoodsGridView ExchangeGoodsGridView ExchangeGoodsGridView Pointer
    // 088 SaveData                                 000186516CF0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer
    public partial class ExchangePopupWindow
    {
        public UITabButton?                             TabPrefab                               { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public List<TabData>?                           TabDatas                                { get; set; }
        public TabData?                                 CurSelectTabData                        { get; set; }
        public ExchangeGoodsGridView?                   GoodsGridView                           { get; set; }
        public ExchangeSaveData?                        SaveData                                { get; set; }

        public static ExchangePopupWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePopupWindow();

            value.TabPrefab                                 = GetObject<UITabButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITabButton.FromPointer); // 0270D54B85F8 0x60 TabPrefab                   ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270D54B8618 0x68 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.TabDatas                                  = GetObjectList<TabData>(new IntPtr(p + 0x070), ReversePrism.DataModels.TabData.FromPointer); // 0270D54B8638 0x70 TabDatas                    ( 000185D23198 ModelClassListType List`1<TabData> List`1<TabData> List<TabData> Pointer )
            value.CurSelectTabData                          = GetObject<TabData>(new IntPtr(p + 0x078), ReversePrism.DataModels.TabData.FromPointer); // 0270D54B8658 0x78 CurSelectTabData            ( 00018664D250 ModelClassType TabData TabData TabData Pointer )
            value.GoodsGridView                             = GetObject<ExchangeGoodsGridView>(new IntPtr(p + 0x080), ReversePrism.DataModels.ExchangeGoodsGridView.FromPointer); // 0270D54B8678 0x80 GoodsGridView               ( 000186509BA0 ModelClassType ExchangeGoodsGridView ExchangeGoodsGridView ExchangeGoodsGridView Pointer )
            value.SaveData                                  = GetObject<ExchangeSaveData>(new IntPtr(p + 0x088), ReversePrism.DataModels.ExchangeSaveData.FromPointer); // 0270D54B8698 0x88 SaveData                    ( 000186516CF0 ModelClassType ExchangeSaveData ExchangeSaveData ExchangeSaveData Pointer )

            return value;
        }
    }
}
