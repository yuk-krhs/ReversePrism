using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PreviewImage                             ModelClassType RawImage RawImage RawImage Pointer
    // 028 PreviewChartAsset                        ModelPrimitiveType string string string String
    // 030 noteDesigns                              Dictionary`2<int, RhythmGameNoteDesign> IL2CPP_TYPE_GENERICINST
    // 038 Option                                   ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 040 RenderTexture                            ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 048 RhythmGameView                           ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer
    // 050 ChartReader                              ModelClassType ChartReader ChartReader ChartReader Pointer
    // 058 ObjectRenderService                      ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer
    // 060 Combo                                    ModelPrimitiveType int int int Int32
    // 064 IsShinyEnabled                           ModelPrimitiveType bool bool bool Bool
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
        public bool                                     IsShinyEnabled                          { get; set; }

        public static LiveSettingPreviewPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingPreviewPresenter() { Pointer= p0 };

            value.PreviewImage                              = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 PreviewImage                ( ModelClassType RawImage RawImage RawImage Pointer )
            value.PreviewChartAsset                         = GetString(new IntPtr(p + 0x028)); // 0x28 PreviewChartAsset           ( ModelPrimitiveType string string string String )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0x38 Option                      ( ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.RenderTexture                             = GetObject<RenderTexture>(new IntPtr(p + 0x040), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x40 RenderTexture               ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.RhythmGameView                            = GetObject<RhythmGameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.RhythmGameView.FromPointer); // 0x48 RhythmGameView              ( ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer )
            value.ChartReader                               = GetObject<ChartReader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChartReader.FromPointer); // 0x50 ChartReader                 ( ModelClassType ChartReader ChartReader ChartReader Pointer )
            value.ObjectRenderService                       = GetObject<RhythmGameObjectRenderService>(new IntPtr(p + 0x058), ReversePrism.DataModels.RhythmGameObjectRenderService.FromPointer); // 0x58 ObjectRenderService         ( ModelClassType RhythmGameObjectRenderService RhythmGameObjectRenderService RhythmGameObjectRenderService Pointer )
            value.Combo                                     = GetInt32(new IntPtr(p + 0x060)); // 0x60 Combo                       ( ModelPrimitiveType int int int Int32 )
            value.IsShinyEnabled                            = GetBool(new IntPtr(p + 0x064)); // 0x64 IsShinyEnabled              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
