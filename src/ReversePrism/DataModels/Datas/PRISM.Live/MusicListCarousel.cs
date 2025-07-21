using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 SelectedMusicView                        ModelClassType MusicListSelectedMusicView MusicListSelectedMusicView MusicListSelectedMusicView Pointer
    // 090 SlideAnimation                           ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    // 098 RandomSelectDuration                     ModelPrimitiveType float float float Single
    // 0A0 RandomSelectBeginEffect                  ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 RandomSelectEndEffects                   ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class MusicListCarousel : DataModel
    {
        public MusicListSelectedMusicView?              SelectedMusicView                       { get; set; }
        public SimpleSlideAnimation?                    SlideAnimation                          { get; set; }
        public float                                    RandomSelectDuration                    { get; set; }
        public GameObject?                              RandomSelectBeginEffect                 { get; set; }
        public List<GameObject>?                        RandomSelectEndEffects                  { get; set; }

        public static MusicListCarousel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListCarousel() { Pointer= p0 };

            value.SelectedMusicView                         = GetObject<MusicListSelectedMusicView>(new IntPtr(p + 0x088), ReversePrism.DataModels.MusicListSelectedMusicView.FromPointer); // 0x88 SelectedMusicView           ( ModelClassType MusicListSelectedMusicView MusicListSelectedMusicView MusicListSelectedMusicView Pointer )
            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x090), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0x90 SlideAnimation              ( ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )
            value.RandomSelectDuration                      = GetSingle(new IntPtr(p + 0x098)); // 0x98 RandomSelectDuration        ( ModelPrimitiveType float float float Single )
            value.RandomSelectBeginEffect                   = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 RandomSelectBeginEffect     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RandomSelectEndEffects                    = GetObjectList<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 RandomSelectEndEffects      ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
