using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 stdout                                   TextWriter IL2CPP_TYPE_CLASS
    // 008 stderr                                   TextWriter IL2CPP_TYPE_CLASS
    // 010 Stdin                                    000186645270 ModelClassType TextReader TextReader TextReader Pointer
    // 018 IsRunningOnAndroid                       000186595E60 ModelPrimitiveType bool bool bool Bool
    // 020 InputEncoding                            00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 028 OutputEncoding                           00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 030 Cancel_event                             000186608300 ModelClassType ConsoleCancelEventHandler ConsoleCancelEventHandler ConsoleCancelEventHandler Pointer
    public partial class Console
    {
        public TextReader?                              Stdin                                   { get; set; }
        public bool                                     IsRunningOnAndroid                      { get; set; }
        public Encoding?                                InputEncoding                           { get; set; }
        public Encoding?                                OutputEncoding                          { get; set; }
        public ConsoleCancelEventHandler?               Cancel_event                            { get; set; }

        public static Console? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Console();

            value.Stdin                                     = GetObject<TextReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextReader.FromPointer); // 0270D6A66008 0x10 Stdin                       ( 000186645270 ModelClassType TextReader TextReader TextReader Pointer )
            value.IsRunningOnAndroid                        = GetBool(new IntPtr(p + 0x018)); // 0270D6A66028 0x18 IsRunningOnAndroid          ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.InputEncoding                             = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0270D6A66048 0x20 InputEncoding               ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.OutputEncoding                            = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0270D6A66068 0x28 OutputEncoding              ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Cancel_event                              = GetObject<ConsoleCancelEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.ConsoleCancelEventHandler.FromPointer); // 0270D6A66088 0x30 Cancel_event                ( 000186608300 ModelClassType ConsoleCancelEventHandler ConsoleCancelEventHandler ConsoleCancelEventHandler Pointer )

            return value;
        }
    }
}
