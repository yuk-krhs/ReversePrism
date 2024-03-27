using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ImmutableDefaultEtwProviderId            Guid IL2CPP_TYPE_VALUETYPE
    // 010 DefaultEtwProviderId                     0001865DC5C0 ModelEnumType Guid Guid Guid Int32
    // 020 EtwProviderCache                         0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 IsVistaOrGreater                         000186595C30 ModelPrimitiveType bool bool bool Bool
    // 030 traceAnnotation                          Func`1<string> IL2CPP_TYPE_GENERICINST
    // 040 EtwProvider                              00018674BAD0 ModelClassType EtwProvider EtwProvider EtwProvider Pointer
    // 048 EtwProviderId                            0001865DBED0 ModelEnumType Guid Guid Guid Int32
    // 038 TransferEventDescriptor                  0001865C8E80 ModelEnumType EventDescriptor EventDescriptor EventDescriptor Int32
    public partial class EtwDiagnosticTrace
    {
        public Guid                                     DefaultEtwProviderId                    { get; set; }
        public Hashtable?                               EtwProviderCache                        { get; set; }
        public bool                                     IsVistaOrGreater                        { get; set; }
        public EtwProvider?                             EtwProvider                             { get; set; }
        public Guid                                     EtwProviderId                           { get; set; }
        public EventDescriptor                          TransferEventDescriptor                 { get; set; }

        public static EtwDiagnosticTrace? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtwDiagnosticTrace();

            value.DefaultEtwProviderId                      = (Guid)GetInt32(new IntPtr(p + 0x010)); // 027004CF93E0 0x10 DefaultEtwProviderId        ( 0001865DC5C0 ModelEnumType Guid Guid Guid Int32 )
            value.EtwProviderCache                          = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 027004CF9400 0x20 EtwProviderCache            ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IsVistaOrGreater                          = GetBool(new IntPtr(p + 0x028)); // 027004CF9420 0x28 IsVistaOrGreater            ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.EtwProvider                               = GetObject<EtwProvider>(new IntPtr(p + 0x040), ReversePrism.DataModels.EtwProvider.FromPointer); // 027004CF9460 0x40 EtwProvider                 ( 00018674BAD0 ModelClassType EtwProvider EtwProvider EtwProvider Pointer )
            value.EtwProviderId                             = (Guid)GetInt32(new IntPtr(p + 0x048)); // 027004CF9480 0x48 EtwProviderId               ( 0001865DBED0 ModelEnumType Guid Guid Guid Int32 )
            value.TransferEventDescriptor                   = (EventDescriptor)GetInt32(new IntPtr(p + 0x038)); // 027004CF94A0 0x38 TransferEventDescriptor     ( 0001865C8E80 ModelEnumType EventDescriptor EventDescriptor EventDescriptor Int32 )

            return value;
        }
    }
}
