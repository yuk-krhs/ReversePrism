using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 registeredChannels                       ArrayList IL2CPP_TYPE_CLASS
    // 008 delayedClientChannels                    ArrayList IL2CPP_TYPE_CLASS
    // 010 CrossContextSink                         ModelClassType CrossContextChannel CrossContextChannel CrossContextChannel Pointer
    // 018 CrossContextUrl                          ModelPrimitiveType string string string String
    // 020 OldStartModeTypes                        ModelClassType IList IList IList Pointer
    public partial class ChannelServices : DataModel
    {
        public CrossContextChannel?                     CrossContextSink                        { get; set; }
        public string                                   CrossContextUrl                         { get; set; }
        public IList?                                   OldStartModeTypes                       { get; set; }

        public static ChannelServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelServices() { Pointer= p0 };

            value.CrossContextSink                          = GetObject<CrossContextChannel>(new IntPtr(p + 0x010), ReversePrism.DataModels.CrossContextChannel.FromPointer); // 0x10 CrossContextSink            ( ModelClassType CrossContextChannel CrossContextChannel CrossContextChannel Pointer )
            value.CrossContextUrl                           = GetString(new IntPtr(p + 0x018)); // 0x18 CrossContextUrl             ( ModelPrimitiveType string string string String )
            value.OldStartModeTypes                         = GetObject<IList>(new IntPtr(p + 0x020), ReversePrism.DataModels.IList.FromPointer); // 0x20 OldStartModeTypes           ( ModelClassType IList IList IList Pointer )

            return value;
        }
    }
}
