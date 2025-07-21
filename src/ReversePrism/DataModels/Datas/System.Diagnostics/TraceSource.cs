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
    // 010 InternalSwitch                           ModelClassType SourceSwitch SourceSwitch SourceSwitch Pointer
    // 018 Listeners                                ModelClassType TraceListenerCollection TraceListenerCollection TraceListenerCollection Pointer
    // 020 Attributes                               ModelClassType StringDictionary StringDictionary StringDictionary Pointer
    // 028 SwitchLevel                              ModelEnumType SourceLevels SourceLevels SourceLevels Int32
    // 030 SourceName                               ModelPrimitiveType string string string String
    // 038 InitCalled                               ModelPrimitiveType bool bool bool Bool
    public partial class TraceSource : DataModel
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
            var value   = new TraceSource() { Pointer= p0 };

            value.InternalSwitch                            = GetObject<SourceSwitch>(new IntPtr(p + 0x010), ReversePrism.DataModels.SourceSwitch.FromPointer); // 0x10 InternalSwitch              ( ModelClassType SourceSwitch SourceSwitch SourceSwitch Pointer )
            value.Listeners                                 = GetObject<TraceListenerCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.TraceListenerCollection.FromPointer); // 0x18 Listeners                   ( ModelClassType TraceListenerCollection TraceListenerCollection TraceListenerCollection Pointer )
            value.Attributes                                = GetObject<StringDictionary>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringDictionary.FromPointer); // 0x20 Attributes                  ( ModelClassType StringDictionary StringDictionary StringDictionary Pointer )
            value.SwitchLevel                               = (SourceLevels)GetInt32(new IntPtr(p + 0x028)); // 0x28 SwitchLevel                 ( ModelEnumType SourceLevels SourceLevels SourceLevels Int32 )
            value.SourceName                                = GetString(new IntPtr(p + 0x030)); // 0x30 SourceName                  ( ModelPrimitiveType string string string String )
            value.InitCalled                                = GetBool(new IntPtr(p + 0x038)); // 0x38 InitCalled                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
