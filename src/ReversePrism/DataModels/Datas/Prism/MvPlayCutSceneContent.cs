using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 018 CameraWorkEvent                          ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer
    // 020 SceneType                                ModelEnumType SceneType SceneType SceneType Int32
    // 028 CutScene                                 ModelClassType CutScene CutScene CutScene Pointer
    // 030 CharacterRootTransform                   ModelClassType Transform Transform Transform Pointer
    // 038 Characters                               ModelClassListType Character[] Character[] List<Character> Pointer
    public partial class MvPlayCutSceneContent : DataModel
    {
        public GameObject?                              GameObject                              { get; set; }
        public CameraWorkEvent?                         CameraWorkEvent                         { get; set; }
        public SceneType                                SceneType                               { get; set; }
        public CutScene?                                CutScene                                { get; set; }
        public Transform?                               CharacterRootTransform                  { get; set; }
        public List<Character>?                         Characters                              { get; set; }

        public static MvPlayCutSceneContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvPlayCutSceneContent() { Pointer= p0 };

            value.GameObject                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 GameObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CameraWorkEvent                           = GetObject<CameraWorkEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.CameraWorkEvent.FromPointer); // 0x18 CameraWorkEvent             ( ModelClassType CameraWorkEvent CameraWorkEvent CameraWorkEvent Pointer )
            value.SceneType                                 = (SceneType)GetInt32(new IntPtr(p + 0x020)); // 0x20 SceneType                   ( ModelEnumType SceneType SceneType SceneType Int32 )
            value.CutScene                                  = GetObject<CutScene>(new IntPtr(p + 0x028), ReversePrism.DataModels.CutScene.FromPointer); // 0x28 CutScene                    ( ModelClassType CutScene CutScene CutScene Pointer )
            value.CharacterRootTransform                    = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 CharacterRootTransform      ( ModelClassType Transform Transform Transform Pointer )
            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x038), ReversePrism.DataModels.Character.FromPointer); // 0x38 Characters                  ( ModelClassListType Character[] Character[] List<Character> Pointer )

            return value;
        }
    }
}
