using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CharacterButtonPrefab                    ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 068 CharacterButtonRoot                      ModelClassType Transform Transform Transform Pointer
    // 070 OnClose                                  Action`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 078 OnChangedFavoriteMark                    Action`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 080 ChangeTargetId                           ModelPrimitiveType int int int Int32
    // 088 SelectedIcon                             ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 090 IconList                                 ModelClassListType List`1<SCharaIconRectView> List`1<SCharaIconRectView> List<SCharaIconRectView> Pointer
    // 098 IsCompletedDisplay                       ModelPrimitiveType bool bool bool Bool
    // 0A0 Param                                    ModelClassType ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam Pointer
    public partial class ProducePreparationSupportSelectPopupContent : DataModel
    {
        public SCharaIconRectView?                      CharacterButtonPrefab                   { get; set; }
        public Transform?                               CharacterButtonRoot                     { get; set; }
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

            value.CharacterButtonPrefab                     = GetObject<SCharaIconRectView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x60 CharacterButtonPrefab       ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.CharacterButtonRoot                       = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 CharacterButtonRoot         ( ModelClassType Transform Transform Transform Pointer )
            value.ChangeTargetId                            = GetInt32(new IntPtr(p + 0x080)); // 0x80 ChangeTargetId              ( ModelPrimitiveType int int int Int32 )
            value.SelectedIcon                              = GetObject<SCharaIcon>(new IntPtr(p + 0x088), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x88 SelectedIcon                ( ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.IconList                                  = GetObjectList<SCharaIconRectView>(new IntPtr(p + 0x090), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x90 IconList                    ( ModelClassListType List`1<SCharaIconRectView> List`1<SCharaIconRectView> List<SCharaIconRectView> Pointer )
            value.IsCompletedDisplay                        = GetBool(new IntPtr(p + 0x098)); // 0x98 IsCompletedDisplay          ( ModelPrimitiveType bool bool bool Bool )
            value.Param                                     = GetObject<ProducePreparationSupportSelectPopupParam>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ProducePreparationSupportSelectPopupParam.FromPointer); // 0xA0 Param                       ( ModelClassType ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam ProducePreparationSupportSelectPopupParam Pointer )

            return value;
        }
    }
}
