using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneCreateData                          ModelClassType Data Data Data Pointer
    // 018 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 UnitScene                                ModelClassType GameObject GameObject GameObject Pointer
    // 028 CharacterParent                          ModelClassType GameObject GameObject GameObject Pointer
    // 030 Bg                                       ModelClassType GameObject GameObject GameObject Pointer
    // 038 Timeline                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 040 Character                                ModelClassListType Character[] Character[] List<Character> Pointer
    // 048 Frame                                    ModelPrimitiveType float float float Single
    // 04C AnimationFrame                           ModelPrimitiveType float float float Single
    // 050 LiveCharacterController                  ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 058 CamEvent                                 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 060 CueSheet                                 ModelPrimitiveType string string string String
    // 068 CueName                                  ModelPrimitiveType string string string String
    // 070 FirstSectionFrame                        ModelPrimitiveType int int int Int32
    // 074 SecondSectionFrame                       ModelPrimitiveType int int int Int32
    public partial class UnitSceneData : DataModel
    {
        public Data?                                    SceneCreateData                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public GameObject?                              UnitScene                               { get; set; }
        public GameObject?                              CharacterParent                         { get; set; }
        public GameObject?                              Bg                                      { get; set; }
        public PlayableDirector?                        Timeline                                { get; set; }
        public List<Character>?                         Character                               { get; set; }
        public float                                    Frame                                   { get; set; }
        public float                                    AnimationFrame                          { get; set; }
        public LiveCharacterController?                 LiveCharacterController                 { get; set; }
        public CameraWorkEvent?                         CamEvent                                { get; set; }
        public string                                   CueSheet                                { get; set; }
        public string                                   CueName                                 { get; set; }
        public int                                      FirstSectionFrame                       { get; set; }
        public int                                      SecondSectionFrame                      { get; set; }

        public static UnitSceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitSceneData() { Pointer= p0 };

            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x010), ReversePrism.DataModels.Data.FromPointer); // 0x10 SceneCreateData             ( ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x18 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.UnitScene                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 UnitScene                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterParent                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 CharacterParent             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Bg                                        = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 Bg                          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Timeline                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x38 Timeline                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.Character                                 = GetObjectList<Character>(new IntPtr(p + 0x040), ReversePrism.DataModels.Character.FromPointer); // 0x40 Character                   ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x048)); // 0x48 Frame                       ( ModelPrimitiveType float float float Single )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x04C)); // 0x4C AnimationFrame              ( ModelPrimitiveType float float float Single )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x50 LiveCharacterController     ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x058), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x58 CamEvent                    ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.CueSheet                                  = GetString(new IntPtr(p + 0x060)); // 0x60 CueSheet                    ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x068)); // 0x68 CueName                     ( ModelPrimitiveType string string string String )
            value.FirstSectionFrame                         = GetInt32(new IntPtr(p + 0x070)); // 0x70 FirstSectionFrame           ( ModelPrimitiveType int int int Int32 )
            value.SecondSectionFrame                        = GetInt32(new IntPtr(p + 0x074)); // 0x74 SecondSectionFrame          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
