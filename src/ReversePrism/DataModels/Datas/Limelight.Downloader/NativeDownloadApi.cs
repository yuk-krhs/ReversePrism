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
    // 020 Config                                   ModelClassType SonicboomConfig SonicboomConfig SonicboomConfig Pointer
    // 028 RequestPoolSize                          ModelPrimitiveType int int int Int32
    // 030 alreadyCreatedDirectories                HashSet`1<string> IL2CPP_TYPE_GENERICINST
    // 038 CurrentSoftStreamLimit                   ModelPrimitiveType int int int Int32
    public partial class NativeDownloadApi : DataModel
    {
        public SonicboomConfig?                         Config                                  { get; set; }
        public int                                      RequestPoolSize                         { get; set; }
        public int                                      CurrentSoftStreamLimit                  { get; set; }

        public static NativeDownloadApi? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadApi() { Pointer= p0 };

            value.Config                                    = GetObject<SonicboomConfig>(new IntPtr(p + 0x020), ReversePrism.DataModels.SonicboomConfig.FromPointer); // 0x20 Config                      ( ModelClassType SonicboomConfig SonicboomConfig SonicboomConfig Pointer )
            value.RequestPoolSize                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 RequestPoolSize             ( ModelPrimitiveType int int int Int32 )
            value.CurrentSoftStreamLimit                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 CurrentSoftStreamLimit      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
