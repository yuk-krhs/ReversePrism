using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 gashaNamePlateSECueSheetName             string IL2CPP_TYPE_STRING
    // 020 P7Prefab                                 000186658480 ModelClassType MovieP7 MovieP7 MovieP7 Pointer
    // 028 PhaseParent                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 MoviePlayer                              000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 038 GashaNamePlateP                          0001866089D0 ModelClassType GashaNamePlateEx GashaNamePlateEx GashaNamePlateEx Pointer
    // 040 GashaNamePlateS                          0001866090A0 ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer
    // 048 TouchDetector                            0001866CCDB0 ModelClassType Image Image Image Pointer
    // 050 ImgWhite                                 0001866CCDB0 ModelClassType Image Image Image Pointer
    // 058 MovieP7                                  000186658480 ModelClassType MovieP7 MovieP7 MovieP7 Pointer
    // 060 GashaS3Setting                           0001866182B0 ModelClassType GashaS3Setting GashaS3Setting GashaS3Setting Pointer
    // 068 Model                                    000186659170 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer
    // 070 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class MoviePlayerView
    {
        public MovieP7?                                 P7Prefab                                { get; set; }
        public GameObject?                              PhaseParent                             { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public GashaNamePlateEx?                        GashaNamePlateP                         { get; set; }
        public GashaNamePlateS?                         GashaNamePlateS                         { get; set; }
        public Image?                                   TouchDetector                           { get; set; }
        public Image?                                   ImgWhite                                { get; set; }
        public MovieP7?                                 MovieP7                                 { get; set; }
        public GashaS3Setting?                          GashaS3Setting                          { get; set; }
        public MoviePlayerModel?                        Model                                   { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static MoviePlayerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoviePlayerView();

            value.P7Prefab                                  = GetObject<MovieP7>(new IntPtr(p + 0x020), ReversePrism.DataModels.MovieP7.FromPointer); // 0270DA26EA48 0x20 P7Prefab                    ( 000186658480 ModelClassType MovieP7 MovieP7 MovieP7 Pointer )
            value.PhaseParent                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA26EA68 0x28 PhaseParent                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0270DA26EA88 0x30 MoviePlayer                 ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.GashaNamePlateP                           = GetObject<GashaNamePlateEx>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaNamePlateEx.FromPointer); // 0270DA26EAA8 0x38 GashaNamePlateP             ( 0001866089D0 ModelClassType GashaNamePlateEx GashaNamePlateEx GashaNamePlateEx Pointer )
            value.GashaNamePlateS                           = GetObject<GashaNamePlateS>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaNamePlateS.FromPointer); // 0270DA26EAC8 0x40 GashaNamePlateS             ( 0001866090A0 ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer )
            value.TouchDetector                             = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0270DA26EAE8 0x48 TouchDetector               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ImgWhite                                  = GetObject<Image>(new IntPtr(p + 0x050), ReversePrism.DataModels.Image.FromPointer); // 0270DA26EB08 0x50 ImgWhite                    ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.MovieP7                                   = GetObject<MovieP7>(new IntPtr(p + 0x058), ReversePrism.DataModels.MovieP7.FromPointer); // 0270DA26EB28 0x58 MovieP7                     ( 000186658480 ModelClassType MovieP7 MovieP7 MovieP7 Pointer )
            value.GashaS3Setting                            = GetObject<GashaS3Setting>(new IntPtr(p + 0x060), ReversePrism.DataModels.GashaS3Setting.FromPointer); // 0270DA26EB48 0x60 GashaS3Setting              ( 0001866182B0 ModelClassType GashaS3Setting GashaS3Setting GashaS3Setting Pointer )
            value.Model                                     = GetObject<MoviePlayerModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.MoviePlayerModel.FromPointer); // 0270DA26EB68 0x68 Model                       ( 000186659170 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0270DA26EB88 0x70 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
