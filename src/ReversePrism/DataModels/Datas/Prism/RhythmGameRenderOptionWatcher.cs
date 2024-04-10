using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundFilter                         000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 Lane                                     000186778710 ModelClassType Lane Lane Lane Pointer
    // 030 LifeGauge                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ScoreGauge                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 LifeWarning                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 SkillEffectObjects                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 ComboViews                               000185B763B0 ModelClassListType ComboView[] ComboView[] List<ComboView> Pointer
    // 058 Camera3d                                 0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 060 CurrentComboView                         0001865DF660 ModelClassType ComboView ComboView ComboView Pointer
    // 068 IsShowPerfectComboEffect                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RhythmGameRenderOptionWatcher : DataModel
    {
        public SpriteRenderer?                          BackgroundFilter                        { get; set; }
        public Lane?                                    Lane                                    { get; set; }
        public GameObject?                              LifeGauge                               { get; set; }
        public GameObject?                              ScoreGauge                              { get; set; }
        public GameObject?                              LifeWarning                             { get; set; }
        public List<GameObject>?                        SkillEffectObjects                      { get; set; }
        public List<ComboView>?                         ComboViews                              { get; set; }
        public Camera?                                  Camera3d                                { get; set; }
        public ComboView?                               CurrentComboView                        { get; set; }
        public bool                                     IsShowPerfectComboEffect                { get; set; }

        public static RhythmGameRenderOptionWatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameRenderOptionWatcher() { Pointer= p0 };

            value.BackgroundFilter                          = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 024664F24900 0x20 BackgroundFilter            ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.Lane                                      = GetObject<Lane>(new IntPtr(p + 0x028), ReversePrism.DataModels.Lane.FromPointer); // 024664F24920 0x28 Lane                        ( 000186778710 ModelClassType Lane Lane Lane Pointer )
            value.LifeGauge                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 024664F24940 0x30 LifeGauge                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreGauge                                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024664F24960 0x38 ScoreGauge                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LifeWarning                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024664F24980 0x40 LifeWarning                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillEffectObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024664F249A0 0x48 SkillEffectObjects          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ComboViews                                = GetObjectList<ComboView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ComboView.FromPointer); // 024664F249C0 0x50 ComboViews                  ( 000185B763B0 ModelClassListType ComboView[] ComboView[] List<ComboView> Pointer )
            value.Camera3d                                  = GetObject<Camera>(new IntPtr(p + 0x058), ReversePrism.DataModels.Camera.FromPointer); // 024664F249E0 0x58 Camera3d                    ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.CurrentComboView                          = GetObject<ComboView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ComboView.FromPointer); // 024664F24A00 0x60 CurrentComboView            ( 0001865DF660 ModelClassType ComboView ComboView ComboView Pointer )
            value.IsShowPerfectComboEffect                  = GetBool(new IntPtr(p + 0x068)); // 024664F24A20 0x68 IsShowPerfectComboEffect    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
