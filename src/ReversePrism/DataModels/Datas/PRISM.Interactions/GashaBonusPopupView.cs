using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UITabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 UITabStepGroup                           0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 GoStep                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 GoItem                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GoXml                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 GoEmpty                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 GashaBonusRateView                       0001865F2B10 ModelClassType GashaBonusRateView GashaBonusRateView GashaBonusRateView Pointer
    // 058 XMLPanel                                 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 060 IsStep                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 064 TabIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 StepTabIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 RateList                                 000185CF9428 ModelClassListType IReadOnlyList`1<IGashaBonusRateStatus> IReadOnlyList`1<IGashaBonusRateStatus> List<IGashaBonusRateStatus> Pointer
    // 078 XMLPanelInstance                         000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 080 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaBonusPopupView : DataModel
    {
        public UITabGroup?                              UITabGroup                              { get; set; }
        public UITabGroup?                              UITabStepGroup                          { get; set; }
        public GameObject?                              GoStep                                  { get; set; }
        public GameObject?                              GoItem                                  { get; set; }
        public GameObject?                              GoXml                                   { get; set; }
        public GameObject?                              GoEmpty                                 { get; set; }
        public GashaBonusRateView?                      GashaBonusRateView                      { get; set; }
        public XMLPanel?                                XMLPanel                                { get; set; }
        public bool                                     IsStep                                  { get; set; }
        public int                                      TabIndex                                { get; set; }
        public int                                      StepTabIndex                            { get; set; }
        public List<IGashaBonusRateStatus>?             RateList                                { get; set; }
        public XMLPanel?                                XMLPanelInstance                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaBonusPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBonusPopupView() { Pointer= p0 };

            value.UITabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466BA6E8A0 0x20 UITabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.UITabStepGroup                            = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466BA6E8C0 0x28 UITabStepGroup              ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.GoStep                                    = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA6E8E0 0x30 GoStep                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoItem                                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA6E900 0x38 GoItem                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoXml                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA6E920 0x40 GoXml                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoEmpty                                   = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA6E940 0x48 GoEmpty                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaBonusRateView                        = GetObject<GashaBonusRateView>(new IntPtr(p + 0x050), ReversePrism.DataModels.GashaBonusRateView.FromPointer); // 02466BA6E960 0x50 GashaBonusRateView          ( 0001865F2B10 ModelClassType GashaBonusRateView GashaBonusRateView GashaBonusRateView Pointer )
            value.XMLPanel                                  = GetObject<XMLPanel>(new IntPtr(p + 0x058), ReversePrism.DataModels.XMLPanel.FromPointer); // 02466BA6E980 0x58 XMLPanel                    ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.IsStep                                    = GetBool(new IntPtr(p + 0x060)); // 02466BA6E9A0 0x60 IsStep                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x064)); // 02466BA6E9C0 0x64 TabIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StepTabIndex                              = GetInt32(new IntPtr(p + 0x068)); // 02466BA6E9E0 0x68 StepTabIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RateList                                  = GetObjectList<IGashaBonusRateStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IGashaBonusRateStatus.FromPointer); // 02466BA6EA00 0x70 RateList                    ( 000185CF9428 ModelClassListType IReadOnlyList`1<IGashaBonusRateStatus> IReadOnlyList`1<IGashaBonusRateStatus> List<IGashaBonusRateStatus> Pointer )
            value.XMLPanelInstance                          = GetObject<XMLPanel>(new IntPtr(p + 0x078), ReversePrism.DataModels.XMLPanel.FromPointer); // 02466BA6EA20 0x78 XMLPanelInstance            ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BA6EA60 0x88 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
