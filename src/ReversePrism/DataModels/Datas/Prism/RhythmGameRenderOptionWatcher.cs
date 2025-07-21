using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundFilter                         ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 028 Lane                                     ModelClassType Lane Lane Lane Pointer
    // 030 LifeGauge                                ModelClassType GameObject GameObject GameObject Pointer
    // 038 ScoreGauge                               ModelClassType GameObject GameObject GameObject Pointer
    // 040 LifeWarning                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 SkillEffectObjects                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 ComboViews                               ModelClassListType ComboView[] ComboView[] List<ComboView> Pointer
    // 058 Camera3d                                 ModelClassType Camera Camera Camera Pointer
    // 060 CurrentComboView                         ModelClassType ComboView ComboView ComboView Pointer
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

        public static RhythmGameRenderOptionWatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameRenderOptionWatcher() { Pointer= p0 };

            value.BackgroundFilter                          = GetObject<SpriteRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0x20 BackgroundFilter            ( ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.Lane                                      = GetObject<Lane>(new IntPtr(p + 0x028), ReversePrism.DataModels.Lane.FromPointer); // 0x28 Lane                        ( ModelClassType Lane Lane Lane Pointer )
            value.LifeGauge                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LifeGauge                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreGauge                                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ScoreGauge                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LifeWarning                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 LifeWarning                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillEffectObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 SkillEffectObjects          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ComboViews                                = GetObjectList<ComboView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ComboView.FromPointer); // 0x50 ComboViews                  ( ModelClassListType ComboView[] ComboView[] List<ComboView> Pointer )
            value.Camera3d                                  = GetObject<Camera>(new IntPtr(p + 0x058), ReversePrism.DataModels.Camera.FromPointer); // 0x58 Camera3d                    ( ModelClassType Camera Camera Camera Pointer )
            value.CurrentComboView                          = GetObject<ComboView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ComboView.FromPointer); // 0x60 CurrentComboView            ( ModelClassType ComboView ComboView ComboView Pointer )

            return value;
        }
    }
}
