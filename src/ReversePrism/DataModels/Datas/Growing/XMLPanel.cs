using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 TableView                                ModelClassType UITableView UITableView UITableView Pointer
    // 030 XmlTextItemPrefab                        ModelClassType XMLTextItem XMLTextItem XMLTextItem Pointer
    // 038 XmlImageItemPrefab                       ModelClassType XMLImageItem XMLImageItem XMLImageItem Pointer
    // 040 XmlLinkItemPrefab                        ModelClassType XMLLinkItem XMLLinkItem XMLLinkItem Pointer
    // 048 TextSizeCalculator                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Space                                    ModelPrimitiveType float float float Single
    // 054 TopMargin                                ModelPrimitiveType float float float Single
    // 058 BottomMargin                             ModelPrimitiveType float float float Single
    // 000 DEFAULT_FONT_SIZE                        int IL2CPP_TYPE_I4
    // 05C IsLoaded                                 ModelPrimitiveType bool bool bool Bool
    // 000 FONT_COLOR                               Color IL2CPP_TYPE_VALUETYPE
    // 060 FontSize                                 ModelPrimitiveType int int int Int32
    // 064 LineSpacing                              ModelPrimitiveType float float float Single
    // 068 XmlItems                                 ModelClassListType List`1<XMLItemBaseParam> List`1<XMLItemBaseParam> List<XMLItemBaseParam> Pointer
    // 070 ActiveTasks                              ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer
    // 078 ItemWidth                                ModelPrimitiveType float float float Single
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

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x20 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.TableView                                 = GetObject<UITableView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITableView.FromPointer); // 0x28 TableView                   ( ModelClassType UITableView UITableView UITableView Pointer )
            value.XmlTextItemPrefab                         = GetObject<XMLTextItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.XMLTextItem.FromPointer); // 0x30 XmlTextItemPrefab           ( ModelClassType XMLTextItem XMLTextItem XMLTextItem Pointer )
            value.XmlImageItemPrefab                        = GetObject<XMLImageItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.XMLImageItem.FromPointer); // 0x38 XmlImageItemPrefab          ( ModelClassType XMLImageItem XMLImageItem XMLImageItem Pointer )
            value.XmlLinkItemPrefab                         = GetObject<XMLLinkItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.XMLLinkItem.FromPointer); // 0x40 XmlLinkItemPrefab           ( ModelClassType XMLLinkItem XMLLinkItem XMLLinkItem Pointer )
            value.TextSizeCalculator                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TextSizeCalculator          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Space                                     = GetSingle(new IntPtr(p + 0x050)); // 0x50 Space                       ( ModelPrimitiveType float float float Single )
            value.TopMargin                                 = GetSingle(new IntPtr(p + 0x054)); // 0x54 TopMargin                   ( ModelPrimitiveType float float float Single )
            value.BottomMargin                              = GetSingle(new IntPtr(p + 0x058)); // 0x58 BottomMargin                ( ModelPrimitiveType float float float Single )
            value.IsLoaded                                  = GetBool(new IntPtr(p + 0x05C)); // 0x5C IsLoaded                    ( ModelPrimitiveType bool bool bool Bool )
            value.FontSize                                  = GetInt32(new IntPtr(p + 0x060)); // 0x60 FontSize                    ( ModelPrimitiveType int int int Int32 )
            value.LineSpacing                               = GetSingle(new IntPtr(p + 0x064)); // 0x64 LineSpacing                 ( ModelPrimitiveType float float float Single )
            value.XmlItems                                  = GetObjectList<XMLItemBaseParam>(new IntPtr(p + 0x068), ReversePrism.DataModels.XMLItemBaseParam.FromPointer); // 0x68 XmlItems                    ( ModelClassListType List`1<XMLItemBaseParam> List`1<XMLItemBaseParam> List<XMLItemBaseParam> Pointer )
            value.ActiveTasks                               = GetEnumList<UniTask>(new IntPtr(p + 0x070)); // 0x70 ActiveTasks                 ( ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer )
            value.ItemWidth                                 = GetSingle(new IntPtr(p + 0x078)); // 0x78 ItemWidth                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
