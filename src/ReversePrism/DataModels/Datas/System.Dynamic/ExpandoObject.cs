using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_expandoTryGetValue                     MethodInfo IL2CPP_TYPE_CLASS
    // 008 s_expandoTrySetValue                     MethodInfo IL2CPP_TYPE_CLASS
    // 010 S_expandoTryDeleteValue                  ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 S_expandoPromoteClass                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 S_expandoCheckVersion                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 010 LockObject                               <object> IL2CPP_TYPE_OBJECT
    // 018 Data                                     ModelClassType ExpandoData ExpandoData ExpandoData Pointer
    // 020 Count                                    ModelPrimitiveType int int int Int32
    // 028 Uninitialized                            <object> IL2CPP_TYPE_OBJECT
    // 028 PropertyChanged                          ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    public partial class ExpandoObject : DataModel
    {
        public MethodInfo?                              S_expandoTryDeleteValue                 { get; set; }
        public MethodInfo?                              S_expandoPromoteClass                   { get; set; }
        public MethodInfo?                              S_expandoCheckVersion                   { get; set; }
        public ExpandoData?                             Data                                    { get; set; }
        public int                                      Count                                   { get; set; }
        public PropertyChangedEventHandler?             PropertyChanged                         { get; set; }

        public static ExpandoObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpandoObject() { Pointer= p0 };

            value.S_expandoTryDeleteValue                   = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x10 S_expandoTryDeleteValue     ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_expandoPromoteClass                     = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x18 S_expandoPromoteClass       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_expandoCheckVersion                     = GetObject<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x20 S_expandoCheckVersion       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Data                                      = GetObject<ExpandoData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExpandoData.FromPointer); // 0x18 Data                        ( ModelClassType ExpandoData ExpandoData ExpandoData Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Count                       ( ModelPrimitiveType int int int Int32 )
            value.PropertyChanged                           = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0x28 PropertyChanged             ( ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )

            return value;
        }
    }
}
