using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ImmutableDefaultEtwProviderId            Guid IL2CPP_TYPE_VALUETYPE
    // 010 DefaultEtwProviderId                     ModelEnumType Guid Guid Guid Int32
    // 020 EtwProviderCache                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 IsVistaOrGreater                         ModelPrimitiveType bool bool bool Bool
    // 030 traceAnnotation                          Func`1<string> IL2CPP_TYPE_GENERICINST
    // 040 EtwProvider                              ModelClassType EtwProvider EtwProvider EtwProvider Pointer
    // 048 EtwProviderId                            ModelEnumType Guid Guid Guid Int32
    // 038 TransferEventDescriptor                  ModelEnumType EventDescriptor EventDescriptor EventDescriptor Int32
    public partial class EtwDiagnosticTrace : DataModel
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
            var value   = new EtwDiagnosticTrace() { Pointer= p0 };

            value.DefaultEtwProviderId                      = (Guid)GetInt32(new IntPtr(p + 0x010)); // 0x10 DefaultEtwProviderId        ( ModelEnumType Guid Guid Guid Int32 )
            value.EtwProviderCache                          = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 EtwProviderCache            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IsVistaOrGreater                          = GetBool(new IntPtr(p + 0x028)); // 0x28 IsVistaOrGreater            ( ModelPrimitiveType bool bool bool Bool )
            value.EtwProvider                               = GetObject<EtwProvider>(new IntPtr(p + 0x040), ReversePrism.DataModels.EtwProvider.FromPointer); // 0x40 EtwProvider                 ( ModelClassType EtwProvider EtwProvider EtwProvider Pointer )
            value.EtwProviderId                             = (Guid)GetInt32(new IntPtr(p + 0x048)); // 0x48 EtwProviderId               ( ModelEnumType Guid Guid Guid Int32 )
            value.TransferEventDescriptor                   = (EventDescriptor)GetInt32(new IntPtr(p + 0x038)); // 0x38 TransferEventDescriptor     ( ModelEnumType EventDescriptor EventDescriptor EventDescriptor Int32 )

            return value;
        }
    }
}
