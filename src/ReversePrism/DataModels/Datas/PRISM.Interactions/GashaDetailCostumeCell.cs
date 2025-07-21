using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 PfIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 JumpDressUpButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 048 TxtDressSetName                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 IconViews                                ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer
    // 058 BlankIconViews                           ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 Model                                    ModelClassType GashaDetailCostumeViewModel GashaDetailCostumeViewModel GashaDetailCostumeViewModel Pointer
    // 068 Context                                  ModelClassType GashaDetailCostumeViewContext GashaDetailCostumeViewContext GashaDetailCostumeViewContext Pointer
    // 070 onCostumeIconDetail                      IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    public partial class GashaDetailCostumeCell : DataModel
    {
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public UIButton?                                JumpDressUpButton                       { get; set; }
        public UITextMeshProUGUI?                       TxtDressSetName                         { get; set; }
        public List<CostumeIconView>?                   IconViews                               { get; set; }
        public List<GameObject>?                        BlankIconViews                          { get; set; }
        public GashaDetailCostumeViewModel?             Model                                   { get; set; }
        public GashaDetailCostumeViewContext?           Context                                 { get; set; }

        public static GashaDetailCostumeCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailCostumeCell() { Pointer= p0 };

            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x38 PfIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.JumpDressUpButton                         = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 JumpDressUpButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtDressSetName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtDressSetName             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconViews                                 = GetObjectList<CostumeIconView>(new IntPtr(p + 0x050), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0x50 IconViews                   ( ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer )
            value.BlankIconViews                            = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 BlankIconViews              ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Model                                     = GetObject<GashaDetailCostumeViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaDetailCostumeViewModel.FromPointer); // 0x60 Model                       ( ModelClassType GashaDetailCostumeViewModel GashaDetailCostumeViewModel GashaDetailCostumeViewModel Pointer )
            value.Context                                   = GetObject<GashaDetailCostumeViewContext>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaDetailCostumeViewContext.FromPointer); // 0x68 Context                     ( ModelClassType GashaDetailCostumeViewContext GashaDetailCostumeViewContext GashaDetailCostumeViewContext Pointer )

            return value;
        }
    }
}
