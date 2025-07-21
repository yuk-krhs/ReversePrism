using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 NewData                                  ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 <OnChangeCenter>k__BackingField          Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 048 CenterGashaId                            ModelPrimitiveType string string string String
    // 050 <OnSaveNewData>k__BackingField           Action`1<string> IL2CPP_TYPE_GENERICINST
    // 058 WebTextureLoader                         ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer
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

            value.NewData                                   = GetStringList(new IntPtr(p + 0x038)); // 0x38 NewData                     ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CenterGashaId                             = GetString(new IntPtr(p + 0x048)); // 0x48 CenterGashaId               ( ModelPrimitiveType string string string String )
            value.WebTextureLoader                          = GetObject<WebTextureLoader>(new IntPtr(p + 0x058), ReversePrism.DataModels.WebTextureLoader.FromPointer); // 0x58 WebTextureLoader            ( ModelClassType WebTextureLoader WebTextureLoader WebTextureLoader Pointer )

            return value;
        }
    }
}
