using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 XMLPanelDescription                      ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 028 XMLPanelAttention                        ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 030 GoDescription                            ModelClassType GameObject GameObject GameObject Pointer
    // 038 GoAttention                              ModelClassType GameObject GameObject GameObject Pointer
    // 040 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 048 onNeedGashaNotes                         Func`5<string, IReadOnlyList`1<string>, int, CancellationToken, UniTask`1<string>> IL2CPP_TYPE_GENERICINST
    // 050 GashaId                                  ModelPrimitiveType string string string String
    // 058 DetailIdList                             ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 060 StepNo                                   ModelPrimitiveType int int int Int32
    // 068 GashaDetailXml                           ModelPrimitiveType string string string String
    // 070 Token                                    ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 078 tabSetupFinishFlags                      Dictionary`2<GashaTabType, bool> IL2CPP_TYPE_GENERICINST
    // 080 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaDetailPopupView : DataModel
    {
        public XMLPanel?                                XMLPanelDescription                     { get; set; }
        public XMLPanel?                                XMLPanelAttention                       { get; set; }
        public GameObject?                              GoDescription                           { get; set; }
        public GameObject?                              GoAttention                             { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public string                                   GashaId                                 { get; set; }
        public List<string>?                            DetailIdList                            { get; set; }
        public int                                      StepNo                                  { get; set; }
        public string                                   GashaDetailXml                          { get; set; }
        public CancellationToken                        Token                                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailPopupView() { Pointer= p0 };

            value.XMLPanelDescription                       = GetObject<XMLPanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.XMLPanel.FromPointer); // 0x20 XMLPanelDescription         ( ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.XMLPanelAttention                         = GetObject<XMLPanel>(new IntPtr(p + 0x028), ReversePrism.DataModels.XMLPanel.FromPointer); // 0x28 XMLPanelAttention           ( ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.GoDescription                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoDescription               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoAttention                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 GoAttention                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x40 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.GashaId                                   = GetString(new IntPtr(p + 0x050)); // 0x50 GashaId                     ( ModelPrimitiveType string string string String )
            value.DetailIdList                              = GetStringList(new IntPtr(p + 0x058)); // 0x58 DetailIdList                ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.StepNo                                    = GetInt32(new IntPtr(p + 0x060)); // 0x60 StepNo                      ( ModelPrimitiveType int int int Int32 )
            value.GashaDetailXml                            = GetString(new IntPtr(p + 0x068)); // 0x68 GashaDetailXml              ( ModelPrimitiveType string string string String )
            value.Token                                     = (CancellationToken)GetInt32(new IntPtr(p + 0x070)); // 0x70 Token                       ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x88 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
