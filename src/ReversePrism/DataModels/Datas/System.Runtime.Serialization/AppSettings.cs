using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxMimePartsAppSettingsString            string IL2CPP_TYPE_STRING
    // 000 DefaultMaxMimeParts                      int IL2CPP_TYPE_I4
    // 000 maxMimeParts                             int IL2CPP_TYPE_I4
    // 004 settingsInitalized                       bool IL2CPP_TYPE_BOOLEAN
    // 008 appSettingsLock                          <object> IL2CPP_TYPE_OBJECT
    public partial class AppSettings : DataModel
    {

        public static AppSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppSettings() { Pointer= p0 };


            return value;
        }
    }
}
