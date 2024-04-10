using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CalledDestroy                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 onDestroy                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 DisposablesOnDestroy                     0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 IsMonitoredActivate                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 IsActivated                              000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.CalledDestroy                             = GetBool(new IntPtr(p + 0x020)); // 0245A3A3FAC0 0x20 CalledDestroy               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DisposablesOnDestroy                      = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A3A3FB00 0x30 DisposablesOnDestroy        ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsMonitoredActivate                       = GetBool(new IntPtr(p + 0x038)); // 0245A3A3FB20 0x38 IsMonitoredActivate         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsActivated                               = GetBool(new IntPtr(p + 0x039)); // 0245A3A3FB40 0x39 IsActivated                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
