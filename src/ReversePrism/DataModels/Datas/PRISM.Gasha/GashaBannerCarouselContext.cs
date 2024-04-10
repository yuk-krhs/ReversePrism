using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 NewData                                  000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 038 <OnChangeCenter>k__BackingField          Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 040 CenterGashaId                            0001866722E0 ModelPrimitiveType string string string String
    // 048 <OnSaveNewData>k__BackingField           Action`1<string> IL2CPP_TYPE_GENERICINST
    // 050 WebTextureLoader                         0001865519B0 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
    public partial class GashaBannerCarouselContext : DataModel
    {
        public List<string>?                            NewData                                 { get; set; }
        public string                                   CenterGashaId                           { get; set; }
        public WebTextureLoader?                        WebTextureLoader                        { get; set; }

        public static GashaBannerCarouselContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaBannerCarouselContext() { Pointer= p0 };

            value.NewData                                   = GetStringList(new IntPtr(p + 0x030)); // 02466535AF08 0x30 NewData                     ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CenterGashaId                             = GetString(new IntPtr(p + 0x040)); // 02466535AF48 0x40 CenterGashaId               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.WebTextureLoader                          = GetObject<WebTextureLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 02466535AF88 0x50 WebTextureLoader            ( 0001865519B0 ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
