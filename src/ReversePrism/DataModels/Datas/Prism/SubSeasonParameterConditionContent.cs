using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ConditionCheckMarkOn                     ModelClassType GameObject GameObject GameObject Pointer
    // 028 ConditionCheckMarkOff                    ModelClassType GameObject GameObject GameObject Pointer
    // 030 VoBorderText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 DaBorderText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 040 ViBorderText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 MeBorderText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 VoShortageText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 DaShortageText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 ViShortageText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 068 MeShortageText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 070 VoAchieveObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 078 DaAchieveObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 080 ViAchieveObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 088 MeAchieveObject                          ModelClassType GameObject GameObject GameObject Pointer
    public partial class SubSeasonParameterConditionContent : DataModel
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
            var value   = new SubSeasonParameterConditionContent() { Pointer= p0 };

            value.ConditionCheckMarkOn                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ConditionCheckMarkOn        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ConditionCheckMarkOff                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ConditionCheckMarkOff       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.VoBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 VoBorderText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.DaBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x38 DaBorderText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ViBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x40 ViBorderText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MeBorderText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x48 MeBorderText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.VoShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x50 VoShortageText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.DaShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x58 DaShortageText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ViShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x60 ViShortageText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MeShortageText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x68 MeShortageText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.VoAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 VoAchieveObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DaAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 DaAchieveObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 ViAchieveObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MeAchieveObject                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 MeAchieveObject             ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
