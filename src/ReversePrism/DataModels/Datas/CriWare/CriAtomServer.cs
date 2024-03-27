using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _instance                                CriAtomServer IL2CPP_TYPE_CLASS
    // 030 onApplicationPausePreProcess             Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 onApplicationPausePostProcess            Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 KeepPlayingSoundOnPause                  bool IL2CPP_TYPE_BOOLEAN
    // 009 EnableAutoConsumePcmOutput               bool IL2CPP_TYPE_BOOLEAN
    public partial class CriAtomServer
    {

        public static CriAtomServer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomServer();


            return value;
        }
    }
}
