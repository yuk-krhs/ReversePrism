using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultUpdateUrl                         Uri IL2CPP_TYPE_CLASS
    // 008 Default                                  string IL2CPP_TYPE_STRING
    // 010 Sync                                     <object> IL2CPP_TYPE_OBJECT
    // 018 Instance                                 ModelClassType AppConfigExtensions AppConfigExtensions AppConfigExtensions Pointer
    // 020 SStringState                             Dictionary`2<int, Dictionary`2<string, string>> IL2CPP_TYPE_GENERICINST
    public partial class AppConfigExtensions : DataModel
    {
        public AppConfigExtensions?                     Instance                                { get; set; }

        public static AppConfigExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppConfigExtensions() { Pointer= p0 };

            value.Instance                                  = GetObject<AppConfigExtensions>(new IntPtr(p + 0x018), ReversePrism.DataModels.AppConfigExtensions.FromPointer); // 0x18 Instance                    ( ModelClassType AppConfigExtensions AppConfigExtensions AppConfigExtensions Pointer )

            return value;
        }
    }
}
