using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneCreateData                          0001867106E0 ModelClassType Data Data Data Pointer
    // 018 UnitIdols                                000185CAF268 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 UnitScene                                0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 028 CharacterParent                          0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 030 Bg                                       0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 038 Character                                000185B74DD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 040 Frame                                    000186666050 ModelPrimitiveType float float float Single
    // 044 AnimationFrame                           000186666050 ModelPrimitiveType float float float Single
    // 048 LiveCharacterController                  000186545060 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 050 CamEvent                                 000186539AE0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 058 CueSheet                                 0001866722E0 ModelPrimitiveType string string string String
    // 060 CueName                                  0001866722E0 ModelPrimitiveType string string string String
    // 068 FirstSectionFrame                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 06C SecondSectionFrame                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class UnitSceneData
    {
        public Data?                                    SceneCreateData                         { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public GameObject?                              UnitScene                               { get; set; }
        public GameObject?                              CharacterParent                         { get; set; }
        public GameObject?                              Bg                                      { get; set; }
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
            var value   = new UnitSceneData();

            value.SceneCreateData                           = GetObject<Data>(new IntPtr(p + 0x010), ReversePrism.DataModels.Data.FromPointer); // 0270D4D9B4D0 0x10 SceneCreateData             ( 0001867106E0 ModelClassType Data Data Data Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D4D9B4F0 0x18 UnitIdols                   ( 000185CAF268 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.UnitScene                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D9B510 0x20 UnitScene                   ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterParent                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D9B530 0x28 CharacterParent             ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Bg                                        = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D9B550 0x30 Bg                          ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Character                                 = GetObjectList<Character>(new IntPtr(p + 0x038), ReversePrism.DataModels.Character.FromPointer); // 0270D4D9B570 0x38 Character                   ( 000185B74DD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x040)); // 0270D4D9B590 0x40 Frame                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.AnimationFrame                            = GetSingle(new IntPtr(p + 0x044)); // 0270D4D9B5B0 0x44 AnimationFrame              ( 000186666050 ModelPrimitiveType float float float Single )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0270D4D9B5D0 0x48 LiveCharacterController     ( 000186545060 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CamEvent                                  = GetObject<CameraWorkEvent>(new IntPtr(p + 0x050), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0270D4D9B5F0 0x50 CamEvent                    ( 000186539AE0 ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.CueSheet                                  = GetString(new IntPtr(p + 0x058)); // 0270D4D9B610 0x58 CueSheet                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x060)); // 0270D4D9B630 0x60 CueName                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FirstSectionFrame                         = GetInt32(new IntPtr(p + 0x068)); // 0270D4D9B650 0x68 FirstSectionFrame           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SecondSectionFrame                        = GetInt32(new IntPtr(p + 0x06C)); // 0270D4D9B670 0x6C SecondSectionFrame          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
