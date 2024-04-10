using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CharacterButtonPrefab                    0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 068 CharacterButtonRoot                      0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 070 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 078 OnClose                                  Action`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 080 OnChangedFavoriteMark                    Action`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 088 ChangeTargetId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 SelectedIcon                             0001866A9C80 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 098 IconList                                 000185D05B38 ModelClassListType List`1<SCharaIconRectView> List`1<SCharaIconRectView> List<SCharaIconRectView> Pointer
    // 0A0 IsCompletedDisplay                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 Param                                    000186570BE0 ModelClassType ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam Pointer
    public partial class ProducePreparationSupportSelectPopupContent : DataModel
    {
        public SCharaIconRectView?                      CharacterButtonPrefab                   { get; set; }
        public Transform?                               CharacterButtonRoot                     { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public int                                      ChangeTargetId                          { get; set; }
        public SCharaIcon?                              SelectedIcon                            { get; set; }
        public List<SCharaIconRectView>?                IconList                                { get; set; }
        public bool                                     IsCompletedDisplay                      { get; set; }
        public ProducePreparationSupportSelectPopupParam? Param                                   { get; set; }

        public static ProducePreparationSupportSelectPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationSupportSelectPopupContent() { Pointer= p0 };

            value.CharacterButtonPrefab                     = GetObject<SCharaIconRectView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 024665A9D898 0x60 CharacterButtonPrefab       ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.CharacterButtonRoot                       = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 024665A9D8B8 0x68 CharacterButtonRoot         ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x070), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 024665A9D8D8 0x70 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.ChangeTargetId                            = GetInt32(new IntPtr(p + 0x088)); // 024665A9D938 0x88 ChangeTargetId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedIcon                              = GetObject<SCharaIcon>(new IntPtr(p + 0x090), ReversePrism.DataModels.SCharaIcon.FromPointer); // 024665A9D958 0x90 SelectedIcon                ( 0001866A9C80 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.IconList                                  = GetObjectList<SCharaIconRectView>(new IntPtr(p + 0x098), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 024665A9D978 0x98 IconList                    ( 000185D05B38 ModelClassListType List`1<SCharaIconRectView> List`1<SCharaIconRectView> List<SCharaIconRectView> Pointer )
            value.IsCompletedDisplay                        = GetBool(new IntPtr(p + 0x0A0)); // 024665A9D998 0xA0 IsCompletedDisplay          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Param                                     = GetObject<ProducePreparationSupportSelectPopupParam>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProducePreparationSupportSelectPopupParam.FromPointer); // 024665A9D9B8 0xA8 Param                       ( 000186570BE0 ModelClassType ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam Pointer )

            return value;
        }
    }
}
