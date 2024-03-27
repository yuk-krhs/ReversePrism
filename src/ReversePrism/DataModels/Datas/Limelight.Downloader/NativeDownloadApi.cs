using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LibraryVersion                           uint IL2CPP_TYPE_U4
    // 010 requests                                 <int> IL2CPP_TYPE_I
    // 018 sonicboom                                <int> IL2CPP_TYPE_I
    // 020 Config                                   00018652B810 ModelClassType SonicboomConfig SonicboomConfig SonicboomConfig Pointer
    // 028 RequestPoolSize                          0001865F4260 ModelPrimitiveType int int int Int32
    // 030 alreadyCreatedDirectories                HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 038 CurrentSoftStreamLimit                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class NativeDownloadApi
    {
        public SonicboomConfig?                         Config                                  { get; set; }
        public int                                      RequestPoolSize                         { get; set; }
        public int                                      CurrentSoftStreamLimit                  { get; set; }

        public static NativeDownloadApi? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadApi();

            value.Config                                    = GetObject<SonicboomConfig>(new IntPtr(p + 0x020), ReversePrism.DataModels.SonicboomConfig.FromPointer); // 027003E2C848 0x20 Config                      ( 00018652B810 ModelClassType SonicboomConfig SonicboomConfig SonicboomConfig Pointer )
            value.RequestPoolSize                           = GetInt32(new IntPtr(p + 0x028)); // 027003E2C868 0x28 RequestPoolSize             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CurrentSoftStreamLimit                    = GetInt32(new IntPtr(p + 0x038)); // 027003E2C8A8 0x38 CurrentSoftStreamLimit      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
