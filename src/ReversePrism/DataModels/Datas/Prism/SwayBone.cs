using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Character                                ModelClassType Character Character Character Pointer
    // 028 Root                                     ModelClassType GameObject GameObject GameObject Pointer
    // 030 Atama                                    ModelClassType GameObject GameObject GameObject Pointer
    // 038 KataL                                    ModelClassType GameObject GameObject GameObject Pointer
    // 040 KataR                                    ModelClassType GameObject GameObject GameObject Pointer
    // 048 ArmL                                     ModelClassType GameObject GameObject GameObject Pointer
    // 050 ArmR                                     ModelClassType GameObject GameObject GameObject Pointer
    // 058 ChestL                                   ModelClassType GameObject GameObject GameObject Pointer
    // 060 ChestR                                   ModelClassType GameObject GameObject GameObject Pointer
    // 068 ThighL                                   ModelClassType GameObject GameObject GameObject Pointer
    // 070 ThighR                                   ModelClassType GameObject GameObject GameObject Pointer
    // 078 Spine1                                   ModelClassType GameObject GameObject GameObject Pointer
    // 080 Spine2                                   ModelClassType GameObject GameObject GameObject Pointer
    // 088 CalfL                                    ModelClassType GameObject GameObject GameObject Pointer
    // 090 CalfR                                    ModelClassType GameObject GameObject GameObject Pointer
    // 098 ForeArmL                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 ForeArmR                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 TempAtama                                ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 GroundPlane                              ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0C0 AdditionalSearchBone                     ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 0C8 ListStrings                              ModelClassListType List`1<SwayString> List`1<SwayString> List<SwayString> Pointer
    public partial class SwayBone : DataModel
    {
        public Character?                               Character                               { get; set; }
        public GameObject?                              Root                                    { get; set; }
        public GameObject?                              Atama                                   { get; set; }
        public GameObject?                              KataL                                   { get; set; }
        public GameObject?                              KataR                                   { get; set; }
        public GameObject?                              ArmL                                    { get; set; }
        public GameObject?                              ArmR                                    { get; set; }
        public GameObject?                              ChestL                                  { get; set; }
        public GameObject?                              ChestR                                  { get; set; }
        public GameObject?                              ThighL                                  { get; set; }
        public GameObject?                              ThighR                                  { get; set; }
        public GameObject?                              Spine1                                  { get; set; }
        public GameObject?                              Spine2                                  { get; set; }
        public GameObject?                              CalfL                                   { get; set; }
        public GameObject?                              CalfR                                   { get; set; }
        public GameObject?                              ForeArmL                                { get; set; }
        public GameObject?                              ForeArmR                                { get; set; }
        public GameObject?                              TempAtama                               { get; set; }
        public Vector4                                  GroundPlane                             { get; set; }
        public List<Transform>?                         AdditionalSearchBone                    { get; set; }
        public List<SwayString>?                        ListStrings                             { get; set; }

        public static SwayBone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBone() { Pointer= p0 };

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 0x20 Character                   ( ModelClassType Character Character Character Pointer )
            value.Root                                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 Root                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Atama                                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 Atama                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.KataL                                     = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 KataL                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.KataR                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 KataR                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ArmL                                      = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ArmL                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ArmR                                      = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 ArmR                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChestL                                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ChestL                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChestR                                    = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 ChestR                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ThighL                                    = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 ThighL                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ThighR                                    = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 ThighR                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Spine1                                    = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 Spine1                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Spine2                                    = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 Spine2                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CalfL                                     = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 CalfL                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CalfR                                     = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 CalfR                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ForeArmL                                  = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 ForeArmL                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ForeArmR                                  = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 ForeArmR                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TempAtama                                 = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 TempAtama                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GroundPlane                               = (Vector4)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 GroundPlane                 ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.AdditionalSearchBone                      = GetObjectList<Transform>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Transform.FromPointer); // 0xC0 AdditionalSearchBone        ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.ListStrings                               = GetObjectList<SwayString>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.SwayString.FromPointer); // 0xC8 ListStrings                 ( ModelClassListType List`1<SwayString> List`1<SwayString> List<SwayString> Pointer )

            return value;
        }
    }
}
