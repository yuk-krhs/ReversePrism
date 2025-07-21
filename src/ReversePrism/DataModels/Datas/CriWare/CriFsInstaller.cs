using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 InstallBuffer                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 InstallBufferGch                         ModelEnumType GCHandle GCHandle GCHandle Int32
    // 030 handle                                   <int> IL2CPP_TYPE_I
    public partial class CriFsInstaller : DataModel
    {
        public List<sbyte>?                             InstallBuffer                           { get; set; }
        public GCHandle                                 InstallBufferGch                        { get; set; }

        public static CriFsInstaller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsInstaller() { Pointer= p0 };

            value.InstallBuffer                             = GetSByteList(new IntPtr(p + 0x020)); // 0x20 InstallBuffer               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.InstallBufferGch                          = (GCHandle)GetInt32(new IntPtr(p + 0x028)); // 0x28 InstallBufferGch            ( ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
