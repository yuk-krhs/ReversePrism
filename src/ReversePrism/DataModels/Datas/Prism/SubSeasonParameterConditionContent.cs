using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ConditionCheckMarkOn                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ConditionCheckMarkOff                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 VoBorderText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 DaBorderText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 040 ViBorderText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 MeBorderText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 VoShortageText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 DaShortageText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 ViShortageText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 068 MeShortageText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 070 VoAchieveObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 DaAchieveObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 ViAchieveObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 MeAchieveObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class SubSeasonParameterConditionContent
    {
        public GameObject?                              ConditionCheckMarkOn                    { get; set; }
        public GameObject?                              ConditionCheckMarkOff                   { get; set; }
        public TextMeshProUGUI?                         VoBorderText                            { get; set; }
        public TextMeshProUGUI?                         DaBorderText                            { get; set; }
        public TextMeshProUGUI?                         ViBorderText                            { get; set; }
        public TextMeshProUGUI?                         MeBorderText                            { get; set; }
        public TextMeshProUGUI?                         VoShortageText                          { get; set; }
        public TextMeshProUGUI?                         DaShortageText                          { get; set; }
        public TextMeshProUGUI?                         ViShortageText                          { get; set; }
        public TextMeshProUGUI?                         MeShortageText                          { get; set; }
        public GameObject?                              VoAchieveObject                         { get; set; }
        public GameObject?                              DaAchieveObject                         { get; set; }
        public GameObject?                              ViAchieveObject                         { get; set; }
        public GameObject?                              MeAchieveObject                         { get; set; }

        public static SubSeasonParameterConditionContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonParameterConditionContent();

            value.ConditionCheckMarkOn                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D26418 0x20 ConditionCheckMarkOn        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ConditionCheckMarkOff                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D26438 0x28 ConditionCheckMarkOff       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.VoBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D26458 0x30 VoBorderText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.DaBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D26478 0x38 DaBorderText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ViBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D26498 0x40 ViBorderText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MeBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D264B8 0x48 MeBorderText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.VoShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D264D8 0x50 VoShortageText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.DaShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D264F8 0x58 DaShortageText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ViShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D26518 0x60 ViShortageText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MeShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D4D26538 0x68 MeShortageText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.VoAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D26558 0x70 VoAchieveObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DaAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D26578 0x78 DaAchieveObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D26598 0x80 ViAchieveObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MeAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D265B8 0x88 MeAchieveObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
