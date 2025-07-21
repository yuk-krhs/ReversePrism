using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Slider                                   ModelClassType Slider Slider Slider Pointer
    // 028 CutMarkContainer                         ModelClassType Transform Transform Transform Pointer
    // 030 CutMarkButton                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 EarlierCutMarkSprite                     ModelClassType Sprite Sprite Sprite Pointer
    // 040 LaterCutMarkSprite                       ModelClassType Sprite Sprite Sprite Pointer
    // 048 onSeek                                   Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 050 TotalTime                                ModelPrimitiveType float float float Single
    // 058 CutMarkTimes                             ModelPrimitiveListType float[] float[] List<float> Pointer
    // 060 CutMarkImages                            ModelClassListType Image[] Image[] List<Image> Pointer
    // 068 CurrentTime                              ModelPrimitiveType float float float Single
    public partial class LiveMVSeekBar : DataModel
    {
        public Slider?                                  Slider                                  { get; set; }
        public Transform?                               CutMarkContainer                        { get; set; }
        public ButtonBase?                              CutMarkButton                           { get; set; }
        public Sprite?                                  EarlierCutMarkSprite                    { get; set; }
        public Sprite?                                  LaterCutMarkSprite                      { get; set; }
        public float                                    TotalTime                               { get; set; }
        public List<float>?                             CutMarkTimes                            { get; set; }
        public List<Image>?                             CutMarkImages                           { get; set; }
        public float                                    CurrentTime                             { get; set; }

        public static LiveMVSeekBar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVSeekBar() { Pointer= p0 };

            value.Slider                                    = GetObject<Slider>(new IntPtr(p + 0x020), ReversePrism.DataModels.Slider.FromPointer); // 0x20 Slider                      ( ModelClassType Slider Slider Slider Pointer )
            value.CutMarkContainer                          = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 CutMarkContainer            ( ModelClassType Transform Transform Transform Pointer )
            value.CutMarkButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 CutMarkButton               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.EarlierCutMarkSprite                      = GetObject<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0x38 EarlierCutMarkSprite        ( ModelClassType Sprite Sprite Sprite Pointer )
            value.LaterCutMarkSprite                        = GetObject<Sprite>(new IntPtr(p + 0x040), ReversePrism.DataModels.Sprite.FromPointer); // 0x40 LaterCutMarkSprite          ( ModelClassType Sprite Sprite Sprite Pointer )
            value.TotalTime                                 = GetSingle(new IntPtr(p + 0x050)); // 0x50 TotalTime                   ( ModelPrimitiveType float float float Single )
            value.CutMarkTimes                              = GetSingleList(new IntPtr(p + 0x058)); // 0x58 CutMarkTimes                ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.CutMarkImages                             = GetObjectList<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 0x60 CutMarkImages               ( ModelClassListType Image[] Image[] List<Image> Pointer )
            value.CurrentTime                               = GetSingle(new IntPtr(p + 0x068)); // 0x68 CurrentTime                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
