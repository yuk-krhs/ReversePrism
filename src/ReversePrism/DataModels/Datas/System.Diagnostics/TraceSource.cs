using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 tracesources                             List`1<WeakReference> IL2CPP_TYPE_GENERICINST
    // 008 s_LastCollectionCount                    int IL2CPP_TYPE_I4
    // 010 InternalSwitch                           00018653B660 ModelClassType SourceSwitch SourceSwitch SourceSwitch Pointer
    // 018 Listeners                                000186699570 ModelClassType TraceListenerCollection TraceListenerCollection TraceListenerCollection Pointer
    // 020 Attributes                               0001865BD230 ModelClassType StringDictionary StringDictionary StringDictionary Pointer
    // 028 SwitchLevel                              00018653A940 ModelEnumType SourceLevels SourceLevels SourceLevels Int32
    // 030 SourceName                               000186671910 ModelPrimitiveType string string string String
    // 038 InitCalled                               000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class TraceSource
    {
        public SourceSwitch?                            InternalSwitch                          { get; set; }
        public TraceListenerCollection?                 Listeners                               { get; set; }
        public StringDictionary?                        Attributes                              { get; set; }
        public SourceLevels                             SwitchLevel                             { get; set; }
        public string                                   SourceName                              { get; set; }
        public bool                                     InitCalled                              { get; set; }

        public static TraceSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceSource();

            value.InternalSwitch                            = GetObject<SourceSwitch>(new IntPtr(p + 0x010), ReversePrism.DataModels.SourceSwitch.FromPointer); // 027004CF9BD0 0x10 InternalSwitch              ( 00018653B660 ModelClassType SourceSwitch SourceSwitch SourceSwitch Pointer )
            value.Listeners                                 = GetObject<TraceListenerCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.TraceListenerCollection.FromPointer); // 027004CF9BF0 0x18 Listeners                   ( 000186699570 ModelClassType TraceListenerCollection TraceListenerCollection TraceListenerCollection Pointer )
            value.Attributes                                = GetObject<StringDictionary>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringDictionary.FromPointer); // 027004CF9C10 0x20 Attributes                  ( 0001865BD230 ModelClassType StringDictionary StringDictionary StringDictionary Pointer )
            value.SwitchLevel                               = (SourceLevels)GetInt32(new IntPtr(p + 0x028)); // 027004CF9C30 0x28 SwitchLevel                 ( 00018653A940 ModelEnumType SourceLevels SourceLevels SourceLevels Int32 )
            value.SourceName                                = GetString(new IntPtr(p + 0x030)); // 027004CF9C50 0x30 SourceName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.InitCalled                                = GetBool(new IntPtr(p + 0x038)); // 027004CF9C70 0x38 InitCalled                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
