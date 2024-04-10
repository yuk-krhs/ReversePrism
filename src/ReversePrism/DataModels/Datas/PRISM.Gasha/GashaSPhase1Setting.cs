using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Obj01                                    000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 Obj02                                    000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 Obj03                                    000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 MobileDisplayBaseMaterial                00018660BDD0 ModelClassType Material Material Material Pointer
    // 040 MobileDisplayTextMaterial                00018660BDD0 ModelClassType Material Material Material Pointer
    // 048 Tex2ds                                   000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 050 Tex2dGold                                000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 058 Tex2dNormal                              000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 060 Tex2dRainbow                             000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 068 Calenders                                000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 Tvs                                      000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 HandUp                                   0001866792B0 ModelClassType Action Action Action Pointer
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

            value.Obj01                                     = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024665449208 0x20 Obj01                       ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Obj02                                     = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665449228 0x28 Obj02                       ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Obj03                                     = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 024665449248 0x30 Obj03                       ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MobileDisplayBaseMaterial                 = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 024665449268 0x38 MobileDisplayBaseMaterial   ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.MobileDisplayTextMaterial                 = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 024665449288 0x40 MobileDisplayTextMaterial   ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.Tex2ds                                    = GetObjectList<Texture2D>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture2D.FromPointer); // 0246654492A8 0x48 Tex2ds                      ( 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.Tex2dGold                                 = GetObject<Texture2D>(new IntPtr(p + 0x050), ReversePrism.DataModels.Texture2D.FromPointer); // 0246654492C8 0x50 Tex2dGold                   ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Tex2dNormal                               = GetObject<Texture2D>(new IntPtr(p + 0x058), ReversePrism.DataModels.Texture2D.FromPointer); // 0246654492E8 0x58 Tex2dNormal                 ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Tex2dRainbow                              = GetObject<Texture2D>(new IntPtr(p + 0x060), ReversePrism.DataModels.Texture2D.FromPointer); // 024665449308 0x60 Tex2dRainbow                ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Calenders                                 = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024665449328 0x68 Calenders                   ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Tvs                                       = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665449348 0x70 Tvs                         ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.HandUp                                    = GetObject<Action>(new IntPtr(p + 0x078), ReversePrism.DataModels.Action.FromPointer); // 024665449368 0x78 HandUp                      ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
