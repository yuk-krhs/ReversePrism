using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 TableView                                0001866F6320 ModelClassType UITableView UITableView UITableView Pointer
    // 030 XmlTextItemPrefab                        0001865797A0 ModelClassType XMLTextItem XMLTextItem XMLTextItem Pointer
    // 038 XmlImageItemPrefab                       0001865774A0 ModelClassType XMLImageItem XMLImageItem XMLImageItem Pointer
    // 040 XmlLinkItemPrefab                        000186578600 ModelClassType XMLLinkItem XMLLinkItem XMLLinkItem Pointer
    // 048 TextSizeCalculator                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Space                                    0001866656B0 ModelPrimitiveType float float float Single
    // 054 TopMargin                                0001866656B0 ModelPrimitiveType float float float Single
    // 058 BottomMargin                             0001866656B0 ModelPrimitiveType float float float Single
    // 000 DEFAULT_FONT_SIZE                        int IL2CPP_TYPE_I4
    // 05C IsLoaded                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 FONT_COLOR                               Color IL2CPP_TYPE_VALUETYPE
    // 060 FontSize                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 LineSpacing                              0001866656B0 ModelPrimitiveType float float float Single
    // 068 XmlItems                                 000185D1D5D8 ModelClassListType List`1<XMLItemBaseParam> List`1<XMLItemBaseParam> List<XMLItemBaseParam> Pointer
    // 070 ActiveTasks                              000185D197E8 ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer
    // 078 ItemWidth                                0001866656B0 ModelPrimitiveType float float float Single
    public partial class XMLPanel : DataModel
    {
        public ScrollRect?                              ScrollRect                              { get; set; }
        public UITableView?                             TableView                               { get; set; }
        public XMLTextItem?                             XmlTextItemPrefab                       { get; set; }
        public XMLImageItem?                            XmlImageItemPrefab                      { get; set; }
        public XMLLinkItem?                             XmlLinkItemPrefab                       { get; set; }
        public UITextMeshProUGUI?                       TextSizeCalculator                      { get; set; }
        public float                                    Space                                   { get; set; }
        public float                                    TopMargin                               { get; set; }
        public float                                    BottomMargin                            { get; set; }
        public bool                                     IsLoaded                                { get; set; }
        public int                                      FontSize                                { get; set; }
        public float                                    LineSpacing                             { get; set; }
        public List<XMLItemBaseParam>?                  XmlItems                                { get; set; }
        public List<UniTask>?                           ActiveTasks                             { get; set; }
        public float                                    ItemWidth                               { get; set; }

        public static XMLPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLPanel() { Pointer= p0 };

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 024664BC4250 0x20 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.TableView                                 = GetObject<UITableView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITableView.FromPointer); // 024664BC4270 0x28 TableView                   ( 0001866F6320 ModelClassType UITableView UITableView UITableView Pointer )
            value.XmlTextItemPrefab                         = GetObject<XMLTextItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.XMLTextItem.FromPointer); // 024664BC4290 0x30 XmlTextItemPrefab           ( 0001865797A0 ModelClassType XMLTextItem XMLTextItem XMLTextItem Pointer )
            value.XmlImageItemPrefab                        = GetObject<XMLImageItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.XMLImageItem.FromPointer); // 024664BC42B0 0x38 XmlImageItemPrefab          ( 0001865774A0 ModelClassType XMLImageItem XMLImageItem XMLImageItem Pointer )
            value.XmlLinkItemPrefab                         = GetObject<XMLLinkItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.XMLLinkItem.FromPointer); // 024664BC42D0 0x40 XmlLinkItemPrefab           ( 000186578600 ModelClassType XMLLinkItem XMLLinkItem XMLLinkItem Pointer )
            value.TextSizeCalculator                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664BC42F0 0x48 TextSizeCalculator          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Space                                     = GetSingle(new IntPtr(p + 0x050)); // 024664BC4310 0x50 Space                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TopMargin                                 = GetSingle(new IntPtr(p + 0x054)); // 024664BC4330 0x54 TopMargin                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.BottomMargin                              = GetSingle(new IntPtr(p + 0x058)); // 024664BC4350 0x58 BottomMargin                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsLoaded                                  = GetBool(new IntPtr(p + 0x05C)); // 024664BC4390 0x5C IsLoaded                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FontSize                                  = GetInt32(new IntPtr(p + 0x060)); // 024664BC43D0 0x60 FontSize                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LineSpacing                               = GetSingle(new IntPtr(p + 0x064)); // 024664BC43F0 0x64 LineSpacing                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.XmlItems                                  = GetObjectList<XMLItemBaseParam>(new IntPtr(p + 0x068), ReversePrism.DataModels.XMLItemBaseParam.FromPointer); // 024664BC4410 0x68 XmlItems                    ( 000185D1D5D8 ModelClassListType List`1<XMLItemBaseParam> List`1<XMLItemBaseParam> List<XMLItemBaseParam> Pointer )
            value.ActiveTasks                               = GetEnumList<UniTask>(new IntPtr(p + 0x070)); // 024664BC4430 0x70 ActiveTasks                 ( 000185D197E8 ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer )
            value.ItemWidth                                 = GetSingle(new IntPtr(p + 0x078)); // 024664BC4450 0x78 ItemWidth                   ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
