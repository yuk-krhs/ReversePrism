using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PreviewImage                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 PreviewChartAsset                        000186671910 ModelPrimitiveType string string string String
    // 030 noteDesigns                              Dictionary`2<int, RhythmGameNoteDesign> IL2CPP_TYPE_GENERICINST
    // 038 Option                                   000186685720 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 040 RenderTexture                            000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 048 RhythmGameView                           00018668E130 ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer
    // 050 ChartReader                              0001865A8940 ModelClassType ChartReader ChartReader ChartReader Pointer
    // 058 ObjectRenderService                      000186684FB0 ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer
    // 060 Combo                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveSettingPreviewPresenter : DataModel
    {
        public RawImage?                                PreviewImage                            { get; set; }
        public string                                   PreviewChartAsset                       { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public RenderTexture?                           RenderTexture                           { get; set; }
        public RhythmGameView?                          RhythmGameView                          { get; set; }
        public ChartReader?                             ChartReader                             { get; set; }
        public RhythmGameObjectRenderService?           ObjectRenderService                     { get; set; }
        public int                                      Combo                                   { get; set; }

        public static LiveSettingPreviewPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingPreviewPresenter() { Pointer= p0 };

            value.PreviewImage                              = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 024665171390 0x20 PreviewImage                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.PreviewChartAsset                         = GetString(new IntPtr(p + 0x028)); // 0246651713B0 0x28 PreviewChartAsset           ( 000186671910 ModelPrimitiveType string string string String )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0246651713F0 0x38 Option                      ( 000186685720 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.RenderTexture                             = GetObject<RenderTexture>(new IntPtr(p + 0x040), ReversePrism.DataModels.RenderTexture.FromPointer); // 024665171410 0x40 RenderTexture               ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.RhythmGameView                            = GetObject<RhythmGameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.RhythmGameView.FromPointer); // 024665171430 0x48 RhythmGameView              ( 00018668E130 ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer )
            value.ChartReader                               = GetObject<ChartReader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChartReader.FromPointer); // 024665171450 0x50 ChartReader                 ( 0001865A8940 ModelClassType ChartReader ChartReader ChartReader Pointer )
            value.ObjectRenderService                       = GetObject<RhythmGameObjectRenderService>(new IntPtr(p + 0x058), ReversePrism.DataModels.RhythmGameObjectRenderService.FromPointer); // 024665171470 0x58 ObjectRenderService         ( 000186684FB0 ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer )
            value.Combo                                     = GetInt32(new IntPtr(p + 0x060)); // 024665171490 0x60 Combo                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
