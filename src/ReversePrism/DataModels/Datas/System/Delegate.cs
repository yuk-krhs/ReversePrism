using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 method_ptr                               <int> IL2CPP_TYPE_I
    // 018 invoke_impl                              <int> IL2CPP_TYPE_I
    // 020 m_target                                 <object> IL2CPP_TYPE_OBJECT
    // 028 method                                   <int> IL2CPP_TYPE_I
    // 030 delegate_trampoline                      <int> IL2CPP_TYPE_I
    // 038 extra_arg                                <int> IL2CPP_TYPE_I
    // 040 method_code                              <int> IL2CPP_TYPE_I
    // 048 interp_method                            <int> IL2CPP_TYPE_I
    // 050 interp_invoke_impl                       <int> IL2CPP_TYPE_I
    // 058 Method_info                              000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 Original_method_info                     000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 068 Data                                     0001866BAFD0 ModelClassType DelegateData DelegateData DelegateData Pointer
    // 070 Method_is_virtual                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Delegate : DataModel
    {
        public MethodInfo?                              Method_info                             { get; set; }
        public MethodInfo?                              Original_method_info                    { get; set; }
        public DelegateData?                            Data                                    { get; set; }
        public bool                                     Method_is_virtual                       { get; set; }

        public static Delegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Delegate() { Pointer= p0 };

            value.Method_info                               = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A1540B98 0x58 Method_info                 ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Original_method_info                      = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A1540BB8 0x60 Original_method_info        ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Data                                      = GetObject<DelegateData>(new IntPtr(p + 0x068), ReversePrism.DataModels.DelegateData.FromPointer); // 0245A1540BD8 0x68 Data                        ( 0001866BAFD0 ModelClassType DelegateData DelegateData DelegateData Pointer )
            value.Method_is_virtual                         = GetBool(new IntPtr(p + 0x070)); // 0245A1540BF8 0x70 Method_is_virtual           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
