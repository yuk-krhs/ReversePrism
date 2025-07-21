using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ProjectConfig                          ModelClassType IProjectConfiguration IProjectConfiguration IProjectConfiguration Pointer
    // 018 <CommonTags>k__BackingField              IReadOnlyDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 020 Handler                                  ModelClassType DiagnosticsHandler DiagnosticsHandler DiagnosticsHandler Pointer
    public partial class DiagnosticsFactory : DataModel
    {
        public IProjectConfiguration?                   M_ProjectConfig                         { get; set; }
        public DiagnosticsHandler?                      Handler                                 { get; set; }

        public static DiagnosticsFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiagnosticsFactory() { Pointer= p0 };

            value.M_ProjectConfig                           = GetObject<IProjectConfiguration>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProjectConfiguration.FromPointer); // 0x10 M_ProjectConfig             ( ModelClassType IProjectConfiguration IProjectConfiguration IProjectConfiguration Pointer )
            value.Handler                                   = GetObject<DiagnosticsHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.DiagnosticsHandler.FromPointer); // 0x20 Handler                     ( ModelClassType DiagnosticsHandler DiagnosticsHandler DiagnosticsHandler Pointer )

            return value;
        }
    }
}
