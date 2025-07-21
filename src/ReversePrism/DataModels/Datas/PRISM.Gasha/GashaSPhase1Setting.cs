using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Obj01                                    ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 Obj02                                    ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 Obj03                                    ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 MobileDisplayBaseMaterial                ModelClassType Material Material Material Pointer
    // 040 MobileDisplayTextMaterial                ModelClassType Material Material Material Pointer
    // 048 Tex2ds                                   ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 050 Tex2dGold                                ModelClassType Texture2D Texture2D Texture2D Pointer
    // 058 Tex2dNormal                              ModelClassType Texture2D Texture2D Texture2D Pointer
    // 060 Tex2dRainbow                             ModelClassType Texture2D Texture2D Texture2D Pointer
    // 068 Calenders                                ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 Tvs                                      ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 HandUp                                   ModelClassType Action Action Action Pointer
    public partial class GashaSPhase1Setting : DataModel
    {
        public List<GameObject>?                        Obj01                                   { get; set; }
        public List<GameObject>?                        Obj02                                   { get; set; }
        public List<GameObject>?                        Obj03                                   { get; set; }
        public Material?                                MobileDisplayBaseMaterial               { get; set; }
        public Material?                                MobileDisplayTextMaterial               { get; set; }
        public List<Texture2D>?                         Tex2ds                                  { get; set; }
        public Texture2D?                               Tex2dGold                               { get; set; }
        public Texture2D?                               Tex2dNormal                             { get; set; }
        public Texture2D?                               Tex2dRainbow                            { get; set; }
        public List<GameObject>?                        Calenders                               { get; set; }
        public List<GameObject>?                        Tvs                                     { get; set; }
        public Action?                                  HandUp                                  { get; set; }

        public static GashaSPhase1Setting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSPhase1Setting() { Pointer= p0 };

            value.Obj01                                     = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 Obj01                       ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Obj02                                     = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 Obj02                       ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Obj03                                     = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 Obj03                       ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MobileDisplayBaseMaterial                 = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 MobileDisplayBaseMaterial   ( ModelClassType Material Material Material Pointer )
            value.MobileDisplayTextMaterial                 = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0x40 MobileDisplayTextMaterial   ( ModelClassType Material Material Material Pointer )
            value.Tex2ds                                    = GetObjectList<Texture2D>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture2D.FromPointer); // 0x48 Tex2ds                      ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.Tex2dGold                                 = GetObject<Texture2D>(new IntPtr(p + 0x050), ReversePrism.DataModels.Texture2D.FromPointer); // 0x50 Tex2dGold                   ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Tex2dNormal                               = GetObject<Texture2D>(new IntPtr(p + 0x058), ReversePrism.DataModels.Texture2D.FromPointer); // 0x58 Tex2dNormal                 ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Tex2dRainbow                              = GetObject<Texture2D>(new IntPtr(p + 0x060), ReversePrism.DataModels.Texture2D.FromPointer); // 0x60 Tex2dRainbow                ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Calenders                                 = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 Calenders                   ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Tvs                                       = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 Tvs                         ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.HandUp                                    = GetObject<Action>(new IntPtr(p + 0x078), ReversePrism.DataModels.Action.FromPointer); // 0x78 HandUp                      ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
