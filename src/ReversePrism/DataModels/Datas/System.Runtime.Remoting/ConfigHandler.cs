using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeEntries                              00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 ChannelInstances                         00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 CurrentChannel                           000186591990 ModelClassType ChannelData ChannelData ChannelData Pointer
    // 028 CurrentProviderData                      00018655EBF0 ModelClassType Stack Stack Stack Pointer
    // 030 CurrentClientUrl                         000186671910 ModelPrimitiveType string string string String
    // 038 AppName                                  000186671910 ModelPrimitiveType string string string String
    // 040 CurrentXmlPath                           000186671910 ModelPrimitiveType string string string String
    // 048 OnlyDelayedChannels                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ConfigHandler : DataModel
    {
        public ArrayList?                               TypeEntries                             { get; set; }
        public ArrayList?                               ChannelInstances                        { get; set; }
        public ChannelData?                             CurrentChannel                          { get; set; }
        public Stack?                                   CurrentProviderData                     { get; set; }
        public string                                   CurrentClientUrl                        { get; set; }
        public string                                   AppName                                 { get; set; }
        public string                                   CurrentXmlPath                          { get; set; }
        public bool                                     OnlyDelayedChannels                     { get; set; }

        public static ConfigHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfigHandler() { Pointer= p0 };

            value.TypeEntries                               = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 024666C2CFA0 0x10 TypeEntries                 ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ChannelInstances                          = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 024666C2CFC0 0x18 ChannelInstances            ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.CurrentChannel                            = GetObject<ChannelData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChannelData.FromPointer); // 024666C2CFE0 0x20 CurrentChannel              ( 000186591990 ModelClassType ChannelData ChannelData ChannelData Pointer )
            value.CurrentProviderData                       = GetObject<Stack>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stack.FromPointer); // 024666C2D000 0x28 CurrentProviderData         ( 00018655EBF0 ModelClassType Stack Stack Stack Pointer )
            value.CurrentClientUrl                          = GetString(new IntPtr(p + 0x030)); // 024666C2D020 0x30 CurrentClientUrl            ( 000186671910 ModelPrimitiveType string string string String )
            value.AppName                                   = GetString(new IntPtr(p + 0x038)); // 024666C2D040 0x38 AppName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrentXmlPath                            = GetString(new IntPtr(p + 0x040)); // 024666C2D060 0x40 CurrentXmlPath              ( 000186671910 ModelPrimitiveType string string string String )
            value.OnlyDelayedChannels                       = GetBool(new IntPtr(p + 0x048)); // 024666C2D080 0x48 OnlyDelayedChannels         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
