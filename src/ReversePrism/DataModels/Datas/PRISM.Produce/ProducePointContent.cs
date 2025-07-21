using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NormalUI                                 ModelClassType GameObject GameObject GameObject Pointer
    // 028 GaugeImage                               ModelClassType UIImage UIImage UIImage Pointer
    // 030 NormalMoleculeText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NormalDenominatorText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NormalUIAnimator                         ModelClassType Animator Animator Animator Pointer
    // 048 LastNormalUIActive                       ModelPrimitiveType bool bool bool Bool
    // 050 MaxUI                                    ModelClassType GameObject GameObject GameObject Pointer
    // 058 MaxMoleculeText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 MaxDenominatorText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 LastMaxUIActive                          ModelPrimitiveType bool bool bool Bool
    // 070 MentalBreakUI                            ModelClassType GameObject GameObject GameObject Pointer
    // 078 MentalBreakTimeText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ProducePointContent : DataModel
    {
        public GameObject?                              NormalUI                                { get; set; }
        public UIImage?                                 GaugeImage                              { get; set; }
        public UITextMeshProUGUI?                       NormalMoleculeText                      { get; set; }
        public UITextMeshProUGUI?                       NormalDenominatorText                   { get; set; }
        public Animator?                                NormalUIAnimator                        { get; set; }
        public bool                                     LastNormalUIActive                      { get; set; }
        public GameObject?                              MaxUI                                   { get; set; }
        public UITextMeshProUGUI?                       MaxMoleculeText                         { get; set; }
        public UITextMeshProUGUI?                       MaxDenominatorText                      { get; set; }
        public bool                                     LastMaxUIActive                         { get; set; }
        public GameObject?                              MentalBreakUI                           { get; set; }
        public UITextMeshProUGUI?                       MentalBreakTimeText                     { get; set; }

        public static ProducePointContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePointContent() { Pointer= p0 };

            value.NormalUI                                  = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 NormalUI                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GaugeImage                                = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 GaugeImage                  ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NormalMoleculeText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 NormalMoleculeText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NormalDenominatorText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 NormalDenominatorText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NormalUIAnimator                          = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0x40 NormalUIAnimator            ( ModelClassType Animator Animator Animator Pointer )
            value.LastNormalUIActive                        = GetBool(new IntPtr(p + 0x048)); // 0x48 LastNormalUIActive          ( ModelPrimitiveType bool bool bool Bool )
            value.MaxUI                                     = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 MaxUI                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MaxMoleculeText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 MaxMoleculeText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MaxDenominatorText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 MaxDenominatorText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LastMaxUIActive                           = GetBool(new IntPtr(p + 0x068)); // 0x68 LastMaxUIActive             ( ModelPrimitiveType bool bool bool Bool )
            value.MentalBreakUI                             = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 MentalBreakUI               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MentalBreakTimeText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 MentalBreakTimeText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
