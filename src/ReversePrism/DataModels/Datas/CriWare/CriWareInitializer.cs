using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 InitializesFileSystem                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 FileSystemConfig                         000186650C40 ModelClassType CriFsConfig CriFsConfig CriFsConfig Pointer
    // 040 InitializesAtom                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 048 AtomConfig                               000186642EC0 ModelClassType CriAtomConfig CriAtomConfig CriAtomConfig Pointer
    // 050 InitializesMana                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 058 ManaConfig                               000186659650 ModelClassType CriManaConfig CriManaConfig CriManaConfig Pointer
    // 060 UseDecrypter                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 068 DecrypterConfig                          00018665CEC0 ModelClassType CriWareDecrypterConfig CriWareDecrypterConfig CriWareDecrypterConfig Pointer
    // 070 DontInitializeOnAwake                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 071 DontDestroyOnLoad                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 000 initializationCount                      int IL2CPP_TYPE_I4
    public partial class CriWareInitializer
    {
        public bool                                     InitializesFileSystem                   { get; set; }
        public CriFsConfig?                             FileSystemConfig                        { get; set; }
        public bool                                     InitializesAtom                         { get; set; }
        public CriAtomConfig?                           AtomConfig                              { get; set; }
        public bool                                     InitializesMana                         { get; set; }
        public CriManaConfig?                           ManaConfig                              { get; set; }
        public bool                                     UseDecrypter                            { get; set; }
        public CriWareDecrypterConfig?                  DecrypterConfig                         { get; set; }
        public bool                                     DontInitializeOnAwake                   { get; set; }
        public bool                                     DontDestroyOnLoad                       { get; set; }

        public static CriWareInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriWareInitializer();

            value.InitializesFileSystem                     = GetBool(new IntPtr(p + 0x030)); // 0270D116F630 0x30 InitializesFileSystem       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FileSystemConfig                          = GetObject<CriFsConfig>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriFsConfig.FromPointer); // 0270D116F650 0x38 FileSystemConfig            ( 000186650C40 ModelClassType CriFsConfig CriFsConfig CriFsConfig Pointer )
            value.InitializesAtom                           = GetBool(new IntPtr(p + 0x040)); // 0270D116F670 0x40 InitializesAtom             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AtomConfig                                = GetObject<CriAtomConfig>(new IntPtr(p + 0x048), ReversePrism.DataModels.CriAtomConfig.FromPointer); // 0270D116F690 0x48 AtomConfig                  ( 000186642EC0 ModelClassType CriAtomConfig CriAtomConfig CriAtomConfig Pointer )
            value.InitializesMana                           = GetBool(new IntPtr(p + 0x050)); // 0270D116F6B0 0x50 InitializesMana             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ManaConfig                                = GetObject<CriManaConfig>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriManaConfig.FromPointer); // 0270D116F6D0 0x58 ManaConfig                  ( 000186659650 ModelClassType CriManaConfig CriManaConfig CriManaConfig Pointer )
            value.UseDecrypter                              = GetBool(new IntPtr(p + 0x060)); // 0270D116F6F0 0x60 UseDecrypter                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DecrypterConfig                           = GetObject<CriWareDecrypterConfig>(new IntPtr(p + 0x068), ReversePrism.DataModels.CriWareDecrypterConfig.FromPointer); // 0270D116F710 0x68 DecrypterConfig             ( 00018665CEC0 ModelClassType CriWareDecrypterConfig CriWareDecrypterConfig CriWareDecrypterConfig Pointer )
            value.DontInitializeOnAwake                     = GetBool(new IntPtr(p + 0x070)); // 0270D116F730 0x70 DontInitializeOnAwake       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DontDestroyOnLoad                         = GetBool(new IntPtr(p + 0x071)); // 0270D116F750 0x71 DontDestroyOnLoad           ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
