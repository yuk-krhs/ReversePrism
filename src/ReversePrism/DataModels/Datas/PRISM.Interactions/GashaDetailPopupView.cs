using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 XMLPanelDescription                      000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 028 XMLPanelAttention                        000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 030 GoDescription                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 GoAttention                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 048 onNeedGashaNotes                         Func`5<string, IReadOnlyList`1<string>, int, CancellationToken, UniTask`1<string>> IL2CPP_TYPE_GENERICINST
    // 050 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 058 DetailIdList                             000185D16F48 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 060 StepNo                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 GashaDetailXml                           000186671910 ModelPrimitiveType string string string String
    // 070 Token                                    00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 078 tabSetupFinishFlags                      Dictionary`2<GashaTabType, bool> IL2CPP_TYPE_GENERICINST
    // 080 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.XMLPanelDescription                       = GetObject<XMLPanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.XMLPanel.FromPointer); // 02466BA70138 0x20 XMLPanelDescription         ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.XMLPanelAttention                         = GetObject<XMLPanel>(new IntPtr(p + 0x028), ReversePrism.DataModels.XMLPanel.FromPointer); // 02466BA70158 0x28 XMLPanelAttention           ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.GoDescription                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA70178 0x30 GoDescription               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoAttention                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA70198 0x38 GoAttention                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466BA701B8 0x40 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.GashaId                                   = GetString(new IntPtr(p + 0x050)); // 02466BA701F8 0x50 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.DetailIdList                              = GetStringList(new IntPtr(p + 0x058)); // 02466BA70218 0x58 DetailIdList                ( 000185D16F48 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.StepNo                                    = GetInt32(new IntPtr(p + 0x060)); // 02466BA70238 0x60 StepNo                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GashaDetailXml                            = GetString(new IntPtr(p + 0x068)); // 02466BA70258 0x68 GashaDetailXml              ( 000186671910 ModelPrimitiveType string string string String )
            value.Token                                     = (CancellationToken)GetInt32(new IntPtr(p + 0x070)); // 02466BA70278 0x70 Token                       ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BA702D8 0x88 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
