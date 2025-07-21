using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CalledDestroy                            ModelPrimitiveType bool bool bool Bool
    // 028 onDestroy                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 DisposablesOnDestroy                     ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 IsMonitoredActivate                      ModelPrimitiveType bool bool bool Bool
    // 039 IsActivated                              ModelPrimitiveType bool bool bool Bool
    public partial class ObservableDestroyTrigger : DataModel
    {
        public bool                                     CalledDestroy                           { get; set; }
        public CompositeDisposable?                     DisposablesOnDestroy                    { get; set; }
        public bool                                     IsMonitoredActivate                     { get; set; }
        public bool                                     IsActivated                             { get; set; }

        public static ObservableDestroyTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableDestroyTrigger() { Pointer= p0 };

            value.CalledDestroy                             = GetBool(new IntPtr(p + 0x020)); // 0x20 CalledDestroy               ( ModelPrimitiveType bool bool bool Bool )
            value.DisposablesOnDestroy                      = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 DisposablesOnDestroy        ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsMonitoredActivate                       = GetBool(new IntPtr(p + 0x038)); // 0x38 IsMonitoredActivate         ( ModelPrimitiveType bool bool bool Bool )
            value.IsActivated                               = GetBool(new IntPtr(p + 0x039)); // 0x39 IsActivated                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
