using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MovieCamera                              ModelClassType Camera Camera Camera Pointer
    // 028 P7Prefab                                 ModelClassType MovieP7 MovieP7 MovieP7 Pointer
    // 030 PhaseParent                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 MoviePlayer                              ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 040 GashaNamePlateP                          ModelClassType GashaNamePlateP GashaNamePlateP GashaNamePlateP Pointer
    // 048 GashaNamePlateS                          ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer
    // 050 TouchDetector                            ModelClassType Image Image Image Pointer
    // 058 ImgWhite                                 ModelClassType Image Image Image Pointer
    // 060 MovieP7                                  ModelClassType MovieP7 MovieP7 MovieP7 Pointer
    // 068 GashaS3Setting                           ModelClassType GashaS3Setting GashaS3Setting GashaS3Setting Pointer
    // 070 Model                                    ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer
    public partial class MovieSequencer : DataModel
    {
        public Camera?                                  MovieCamera                             { get; set; }
        public MovieP7?                                 P7Prefab                                { get; set; }
        public GameObject?                              PhaseParent                             { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public GashaNamePlateP?                         GashaNamePlateP                         { get; set; }
        public GashaNamePlateS?                         GashaNamePlateS                         { get; set; }
        public Image?                                   TouchDetector                           { get; set; }
        public Image?                                   ImgWhite                                { get; set; }
        public MovieP7?                                 MovieP7                                 { get; set; }
        public GashaS3Setting?                          GashaS3Setting                          { get; set; }
        public MoviePlayerModel?                        Model                                   { get; set; }

        public static MovieSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovieSequencer() { Pointer= p0 };

            value.MovieCamera                               = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 MovieCamera                 ( ModelClassType Camera Camera Camera Pointer )
            value.P7Prefab                                  = GetObject<MovieP7>(new IntPtr(p + 0x028), ReversePrism.DataModels.MovieP7.FromPointer); // 0x28 P7Prefab                    ( ModelClassType MovieP7 MovieP7 MovieP7 Pointer )
            value.PhaseParent                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 PhaseParent                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x038), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0x38 MoviePlayer                 ( ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.GashaNamePlateP                           = GetObject<GashaNamePlateP>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaNamePlateP.FromPointer); // 0x40 GashaNamePlateP             ( ModelClassType GashaNamePlateP GashaNamePlateP GashaNamePlateP Pointer )
            value.GashaNamePlateS                           = GetObject<GashaNamePlateS>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaNamePlateS.FromPointer); // 0x48 GashaNamePlateS             ( ModelClassType GashaNamePlateS GashaNamePlateS GashaNamePlateS Pointer )
            value.TouchDetector                             = GetObject<Image>(new IntPtr(p + 0x050), ReversePrism.DataModels.Image.FromPointer); // 0x50 TouchDetector               ( ModelClassType Image Image Image Pointer )
            value.ImgWhite                                  = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0x58 ImgWhite                    ( ModelClassType Image Image Image Pointer )
            value.MovieP7                                   = GetObject<MovieP7>(new IntPtr(p + 0x060), ReversePrism.DataModels.MovieP7.FromPointer); // 0x60 MovieP7                     ( ModelClassType MovieP7 MovieP7 MovieP7 Pointer )
            value.GashaS3Setting                            = GetObject<GashaS3Setting>(new IntPtr(p + 0x068), ReversePrism.DataModels.GashaS3Setting.FromPointer); // 0x68 GashaS3Setting              ( ModelClassType GashaS3Setting GashaS3Setting GashaS3Setting Pointer )
            value.Model                                     = GetObject<MoviePlayerModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.MoviePlayerModel.FromPointer); // 0x70 Model                       ( ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer )

            return value;
        }
    }
}
